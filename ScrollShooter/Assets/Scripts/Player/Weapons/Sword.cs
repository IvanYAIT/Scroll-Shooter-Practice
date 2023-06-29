using DG.Tweening;
using System.Collections;
using UnityEngine;
using Zenject;

namespace Player.Weapon
{
    public class Sword : MonoBehaviour, IWeapon
    {
        [SerializeField] private Transform blade;

        public bool IsActive => gameObject.activeInHierarchy;

        private float _attackRadius;
        private float _attackSpeed;
        private float _attackCooldown;
        private bool onCooldown;

        [Inject]
        public void Construct(WeaponSetting weaponSetting)
        {
            _attackRadius = weaponSetting.AttackRadius;
            _attackSpeed = weaponSetting.AttackSpeed;
            _attackCooldown = weaponSetting.AttackCooldown;
            blade.localPosition = new Vector2(blade.localPosition.x, blade.localPosition.y + (_attackRadius - 1) / 2);
            blade.DOScaleY(_attackRadius, 0);
        }

        public void Attack()
        {
            if (!onCooldown)
            {
                onCooldown = true;
                blade.gameObject.SetActive(true);
                transform.DORotate(new Vector3(0, 0, 360), _attackSpeed, RotateMode.FastBeyond360).OnComplete(() =>
                {
                    blade.gameObject.SetActive(false);
                    StartCoroutine(AttackCooldown());
                });
            }
        }

        private IEnumerator AttackCooldown()
        {
            yield return new WaitForSeconds(_attackCooldown);
            onCooldown = false;
        }
    }
}