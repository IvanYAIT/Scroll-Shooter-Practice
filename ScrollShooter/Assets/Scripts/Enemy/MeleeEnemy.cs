using Player;
using Service;
using UnityEngine;
using Zenject;

namespace Enemy
{
    public class MeleeEnemy : MonoBehaviour, IEnemy
    {
        [SerializeField] private float health;
        [SerializeField] private float speed;
        [SerializeField] private float damage;
        [SerializeField] private LayerMask playerLayerMask;

        private Transform _player;

        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.position, speed * Time.deltaTime);
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            if(LayerEqualityService.Equal(collision.gameObject.layer, playerLayerMask))
            {
                collision.gameObject.GetComponent<HealthSystem>().GetDamage(damage);
            }
        }

        [Inject]
        public void Construct(Transform playerTransform)
        {
            _player = playerTransform;
        }

        public void GetDamage(float damage)
        {
            if (health <= 0)
                gameObject.SetActive(false);
            else
                health -= damage;
        }
    }
}