using Enemy;
using Service;
using UnityEngine;
using Zenject;

namespace Player.Weapon
{
    public class Blade : MonoBehaviour
    {
        [SerializeField] private LayerMask enemyLayerMask;

        public int HitsPerAttack { get; set; }
        public float Damage { get; set; }

        [Inject]
        public void Construct(WeaponSetting weaponSetting)
        {
            HitsPerAttack = weaponSetting.AttacksPerHit;
            Damage = weaponSetting.Damage;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (LayerEqualityService.Equal(collision.gameObject.layer, enemyLayerMask))
            {
                IEnemy enemy = collision.gameObject.GetComponent<IEnemy>();
                for (int i = 0; i < HitsPerAttack; i++)
                    enemy.GetDamage(Damage);
            }
        }
    }
}