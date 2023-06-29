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

        public float AttackRadius { get; private set; }
        public float AttackSpeed { get; set; }
        public float AttackCD { get; set; }

        private bool onCooldown;

        [Inject]
        public void Construct(WeaponSetting weaponSetting)
        {
            AttackRadius = weaponSetting.AttackRadius;
            AttackSpeed = weaponSetting.AttackSpeed;
            AttackCD = weaponSetting.AttackCooldown;
            blade.localPosition = new Vector2(blade.localPosition.x, blade.localPosition.y + (AttackRadius - 1) / 2);
            blade.DOScaleY(AttackRadius, 0);
        }

        private void Update()
        {
            if(Time.timeScale == 1)
            {
                blade.DOScaleY(AttackRadius, 0);
            }
        }

        public void Attack()
        {
            if (!onCooldown)
            {
                onCooldown = true;
                blade.gameObject.SetActive(true);
                transform.DORotate(new Vector3(0, 0, 360), AttackSpeed, RotateMode.FastBeyond360).OnComplete(() =>
                {
                    blade.gameObject.SetActive(false);
                    StartCoroutine(AttackCooldown());
                });
            }
        }

        public void SetRadius(float value)
        {
            AttackRadius += value;
            blade.localPosition = new Vector2(blade.localPosition.x, blade.localPosition.y + (AttackRadius - 1) / 10);
        }

        private IEnumerator AttackCooldown()
        {
            yield return new WaitForSeconds(AttackCD);
            onCooldown = false;
        }
    }
}