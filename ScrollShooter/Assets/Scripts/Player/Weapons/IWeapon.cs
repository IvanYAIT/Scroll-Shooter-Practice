namespace Player.Weapon
{
    public interface IWeapon
    {
        bool IsActive { get; }
        void Attack();
    }
}