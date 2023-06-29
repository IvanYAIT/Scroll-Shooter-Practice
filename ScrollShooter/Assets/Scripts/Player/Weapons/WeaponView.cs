using UnityEngine;

namespace Player.Weapon
{
    public class WeaponView : MonoBehaviour
    {
        [SerializeField] private Sword sword;

        public Sword Sword => sword;
    }
}