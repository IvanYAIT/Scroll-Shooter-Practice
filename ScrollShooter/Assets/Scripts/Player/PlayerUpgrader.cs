using Player.Upgrade;
using Player.Weapon;
using System;
using Zenject;

namespace Player
{
    public class PlayerUpgrader
    {
        public static Action<UpgradeData> OnUpgrade;

        private Sword _sword;
        private PlayerController _playerController;
        private Blade _blade;

        [Inject]
        public PlayerUpgrader(Sword sword, PlayerController playerController, Blade blade)
        {
            _blade = blade;
            _sword = sword;
            _playerController = playerController;
            OnUpgrade += Upgrade;
        }

        public void Upgrade(UpgradeData data)
        {
            switch (data.Type)
            {
                case UpgradeType.Damage:
                    _blade.Damage += _blade.Damage * ((float)data.Value / 100);
                    break;
                case UpgradeType.AttackCooldown:
                    _sword.AttackCD -= _sword.AttackCD * ((float)data.Value / 100);
                    break;
                case UpgradeType.AttackSpeed:
                    _sword.AttackSpeed -= _sword.AttackSpeed * ((float)data.Value / 100);
                    break;
                case UpgradeType.AttackRadius:
                    _sword.SetRadius(_sword.AttackRadius * ((float)data.Value / 100));
                    break;
                case UpgradeType.HitsPerAttack:
                    _blade.HitsPerAttack += data.Value;
                    break;
                case UpgradeType.MovementSpeed:
                    _playerController.Speed += _playerController.Speed * ((float)data.Value / 100);
                    break;
            }
        }
    }
}