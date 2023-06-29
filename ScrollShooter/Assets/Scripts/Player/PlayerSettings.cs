using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "PlayerSettings", menuName = "SO/NewPlayerSettings")]
    public class PlayerSettings : ScriptableObject
    {
        [SerializeField] private float speed;
        [SerializeField] private float health;
        [SerializeField] private float healthPerSecond;
        [SerializeField] private int invulnerable;

        public float Speed => speed;
        public float Health => health;
        public float HealthPerSecond => healthPerSecond;
        public int Invulnerable => invulnerable;
    }
}