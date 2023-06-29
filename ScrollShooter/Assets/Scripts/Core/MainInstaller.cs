using Enemy;
using Player;
using Player.Weapon;
using UI;
using UnityEngine;
using Zenject;

namespace Core
{
    public class MainInstaller : MonoInstaller
    {
        [SerializeField] private PlayerSettings playerSettings;
        [SerializeField] private HealthView healthView;
        [SerializeField] private Rigidbody2D playerRb;
        [SerializeField] private Transform playerTransform;
        [SerializeField] private WeaponSetting weaponSetting;
        [SerializeField] private WeaponView weaponView;
        [SerializeField] private MeleeEnemy enemy;
        [SerializeField] private TransformRange transformRange;
        [SerializeField] private int poolSize;
        [SerializeField] private PauseMenuView pauseMenuView;
        [SerializeField] private Sword sword;
        [SerializeField] private Blade blade;
        [SerializeField] private UpgradesMenuView upgradesMenuView;

        public override void InstallBindings()
        {
            Container.Bind<PlayerSettings>().FromInstance(playerSettings).AsSingle().NonLazy();
            Container.Bind<Rigidbody2D>().FromInstance(playerRb).AsSingle().NonLazy();
            Container.Bind<HealthView>().FromInstance(healthView).AsSingle().NonLazy();
            Container.Bind<Transform>().FromInstance(playerTransform).AsSingle().NonLazy();
            Container.Bind<WeaponSetting>().FromInstance(weaponSetting).AsSingle().NonLazy();
            Container.Bind<WeaponView>().FromInstance(weaponView).AsSingle().NonLazy();
            Container.Bind<int>().FromInstance(poolSize).AsSingle().NonLazy();
            Container.Bind<TransformRange>().FromInstance(transformRange).AsSingle().NonLazy();
            Container.Bind<PauseMenuView>().FromInstance(pauseMenuView).AsSingle().NonLazy();
            Container.Bind<Sword>().FromInstance(sword).AsSingle().NonLazy();
            Container.Bind<Blade>().FromInstance(blade).AsSingle().NonLazy();
            Container.Bind<UpgradesMenuView>().FromInstance(upgradesMenuView).AsSingle().NonLazy();

            Container.Bind<WeaponController>().AsSingle().NonLazy();
            Container.Bind<PlayerController>().AsSingle().NonLazy();
            Container.Bind<PauseMenuController>().AsSingle().NonLazy();
            Container.Bind<PlayerUpgrader>().AsSingle().NonLazy(); 
            Container.Bind<UpgradesMenuController>().AsSingle().NonLazy(); 

            Container.BindFactory<MeleeEnemy, EnemyPool.EnemyFactory>().FromComponentInNewPrefab(enemy);

            Container.Bind<EnemyPool>().AsSingle().NonLazy();
        }
    }
}