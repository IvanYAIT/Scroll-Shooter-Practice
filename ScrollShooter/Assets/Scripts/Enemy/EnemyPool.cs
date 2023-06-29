using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Enemy
{
    public class EnemyPool
    {
        private List<MeleeEnemy> _pool;
        private EnemyFactory _enemyFactory;

        [Inject]
        public EnemyPool(EnemyFactory bulletFactory, int poolSize)
        {
            _enemyFactory = bulletFactory;

            InitPool(poolSize);
        }

        public MeleeEnemy GetFreeElement()
        {
            if (HasFreeElement(out MeleeEnemy element))
                return element;

            return CreateObject(true);
        }

        private void InitPool(int count)
        {
            _pool = new List<MeleeEnemy>();

            for (int i = 0; i < count; i++)
                CreateObject();
        }

        private MeleeEnemy CreateObject(bool isActiveByDefault = false)
        {
            MeleeEnemy enemy = _enemyFactory.Create();
            enemy.gameObject.SetActive(isActiveByDefault);
            _pool.Add(enemy);
            return enemy;
        }

        private bool HasFreeElement(out MeleeEnemy element)
        {
            for (int i = 0; i < _pool.Count; i++)
            {
                if (!_pool[i].gameObject.activeInHierarchy)
                {
                    element = _pool[i];
                    _pool[i].gameObject.SetActive(true);
                    return true;
                }
            }

            element = null;
            return false;
        }

        public class EnemyFactory : PlaceholderFactory<MeleeEnemy> { }
    }
}