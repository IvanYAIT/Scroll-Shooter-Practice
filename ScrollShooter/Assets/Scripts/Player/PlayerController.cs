using Player.Weapon;
using UnityEngine;
using Zenject;

namespace Player
{
    public class PlayerController
    {
        private float _speed;
        private IWeapon _currentWeapon;

        [Inject]
        public PlayerController(PlayerSettings playerSettings, WeaponController weaponController)
        {
            _speed = playerSettings.Speed;
            _currentWeapon = weaponController.CurrentWeapon;
        }

        public void Move(Vector2 direction, Rigidbody2D playerRb)
        {
            playerRb.velocity = new Vector2(direction.x * _speed, direction.y * _speed);
        }

        public void Attack()=> _currentWeapon.Attack();
    }
}