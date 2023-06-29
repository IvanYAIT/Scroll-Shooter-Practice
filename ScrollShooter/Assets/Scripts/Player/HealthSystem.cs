using Core;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Player
{
    public class HealthSystem : MonoBehaviour
    {
        private HealthView _healthView;

        private float _currentHp;
        private float _maxHp;
        private float _hpRegen;
        private int _invulnerable;
        private bool onRegenCooldown;
        private bool OnDamageCooldown;

        [Inject]
        public void Construct(PlayerSettings playerSettings, HealthView healthView)
        {
            _healthView = healthView;
            _maxHp = playerSettings.Health;
            _invulnerable = playerSettings.Invulnerable;
            _currentHp = _maxHp;
            _hpRegen = playerSettings.HealthPerSecond;
            _healthView.HealthSlider.maxValue = _maxHp;
            UpdateView();
        }

        void Update()
        {
            if (!onRegenCooldown)
                StartCoroutine(Regeneration());
        }

        public void GetDamage(float damage)
        {
            if (!OnDamageCooldown)
                StartCoroutine(ReduceHealth(damage));
        }

        private IEnumerator ReduceHealth(float value)
        {
            _currentHp -= value;
            if (_currentHp <= 0)
                Game.OnLose?.Invoke();
            OnDamageCooldown = true;
            yield return new WaitForSeconds(_invulnerable);
            OnDamageCooldown = false;
        }

        private IEnumerator Regeneration()
        {
            onRegenCooldown = true;
            yield return new WaitForSeconds(1);
            if (_currentHp < _maxHp)
                _currentHp += _hpRegen;
            else
                _currentHp = _maxHp;
            UpdateView();
            onRegenCooldown = false;
        }

        private void UpdateView()
        {
            _healthView.HealthSlider.value = _currentHp;
            _healthView.HealthText.text = $"{_currentHp}/{_maxHp}";
        }
            
    }
}