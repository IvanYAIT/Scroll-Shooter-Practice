using System.Collections;
using UnityEngine;
using Zenject;

namespace Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private float spawnCooldown = 1;
        [SerializeField] private int enemiesPerSpawn = 3;

        private TransformRange _spawnBox;
        private EnemyPool _enemyPool;
        private Transform _player;
        private bool onCooldown;

        [Inject]
        public void Construct(TransformRange spawnBox, EnemyPool enemyPool, Transform player)
        {
            _spawnBox = spawnBox;
            _enemyPool = enemyPool;
            _player = player;
        }

        void Update()
        {
            if (!onCooldown)
                StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            for (int i = 0; i < enemiesPerSpawn; i++)
            {
                MeleeEnemy enemy = _enemyPool.GetFreeElement();
                do
                {
                    enemy.gameObject.transform.position = _spawnBox.RandomInRange();
                } while (Vector2.Distance(enemy.gameObject.transform.position, _player.position) <= 2);
                onCooldown = true;
            }
            yield return new WaitForSeconds(spawnCooldown);
            onCooldown = false;
        }
    }
}