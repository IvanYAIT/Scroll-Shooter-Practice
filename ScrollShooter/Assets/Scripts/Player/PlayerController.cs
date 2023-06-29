using Player.Weapon;
using UnityEngine;
using Zenject;

namespace Player
{
    public class PlayerController
    {
        public float Speed { get; set; }
        private IWeapon _currentWeapon;

        [Inject]
        public PlayerController(PlayerSettings playerSettings, WeaponController weaponController)
        {
            Speed = playerSettings.Speed;
            _currentWeapon = weaponController.CurrentWeapon;
        }

        public void Move(Vector2 direction, Rigidbody2D playerRb)
        {
            playerRb.velocity = new Vector2(direction.x * Speed, direction.y * Speed);
        }

        public void Attack()=> _currentWeapon.Attack();
    }
}