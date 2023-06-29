using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        void Start()
        {
            Game game = new Game();
            LevelData.Instance().ChoosenMode = ModeType.Normal;
            LevelData.Instance().ChoosenWeapon = Player.Weapon.WeaponType.Sword;
        }
    }
}