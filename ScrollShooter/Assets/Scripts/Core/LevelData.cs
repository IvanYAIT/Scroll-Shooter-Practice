using Player.Weapon;

namespace Core
{
    public class LevelData
    {
        public WeaponType ChoosenWeapon { get; set; }
        public ModeType ChoosenMode { get; set; }

        private static LevelData instance;

        private LevelData() { }

        public static LevelData Instance()
        {
            if (instance == null)
                instance = new LevelData();
            return instance;
        }
    }
}