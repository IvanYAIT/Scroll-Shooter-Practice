using UnityEngine;

namespace Player.Upgrade
{
    [CreateAssetMenu(fileName = "UpgradeData", menuName = "SO/NewUpgradeData")]
    public class UpgradeData : ScriptableObject
    {
        [SerializeField] private UpgradeRarity rarity;
        [SerializeField] private UpgradeType type;
        [SerializeField] private int value;

        public UpgradeRarity Rarity => rarity;
        public UpgradeType Type => type;
        public int Value => value;
    }
}