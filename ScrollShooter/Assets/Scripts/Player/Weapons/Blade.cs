using Enemy;
using Service;
using UnityEngine;
using Zenject;

namespace Player.Weapon
{
    public class Blade : MonoBehaviour
    {
        [SerializeField] private LayerMask enemyLayerMask;

        private int _attacksPerHit;
        private float _damage;

        [Inject]
        public void Construct(WeaponSetting weaponSetting)
        {
            _attacksPerHit = weaponSetting.AttacksPerHit;
            _damage = weaponSetting.Damage;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (LayerEqualityService.Equal(collision.gameObject.layer, enemyLayerMask))
            {
                IEnemy enemy = collision.gameObject.GetComponent<IEnemy>();
                for (int i = 0; i < _attacksPerHit; i++)
                    enemy.GetDamage(_damage);
            }
        }
    }
}