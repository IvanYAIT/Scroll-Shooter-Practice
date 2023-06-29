using Core;
using Zenject;

namespace Player.Weapon
{
    public class WeaponController
    {
        public IWeapon CurrentWeapon { get; private set; }

        private WeaponView _weaponView;

        [Inject]
        public WeaponController(WeaponView weaponView)
        {
            _weaponView = weaponView;
            SetCurrentWeapone();
        }

        private void SetCurrentWeapone()
        {
            switch (LevelData.Instance().ChoosenWeapon)
            {
                case WeaponType.Sword:
                    CurrentWeapon = _weaponView.Sword;
                    break;
            }
        }
    }
}