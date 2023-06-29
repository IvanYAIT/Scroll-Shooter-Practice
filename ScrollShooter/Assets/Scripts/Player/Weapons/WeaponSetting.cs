using UnityEngine;

namespace Player.Weapon
{
    [CreateAssetMenu(fileName = "WeaponSetting", menuName = "SO/NewWeaponSetting")]
    public class WeaponSetting : ScriptableObject
    {
        [SerializeField] private float damage;
        [SerializeField] private float attackRadius;
        [SerializeField] private float attackCooldown;
        [SerializeField] private float attackSpeed;
        [SerializeField] private int attacksPerHit;

        public float Damage => damage;
        public float AttackRadius => attackRadius;
        public float AttackCooldown => attackCooldown;
        public float AttackSpeed => attackSpeed;
        public int AttacksPerHit => attacksPerHit;

    }
}