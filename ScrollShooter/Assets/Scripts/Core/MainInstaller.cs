using Player;
using Player.Weapon;
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

        public override void InstallBindings()
        {
            Container.Bind<PlayerSettings>().FromInstance(playerSettings).AsSingle().NonLazy();
            Container.Bind<Rigidbody2D>().FromInstance(playerRb).AsSingle().NonLazy();
            Container.Bind<HealthView>().FromInstance(healthView).AsSingle().NonLazy();
            Container.Bind<Transform>().FromInstance(playerTransform).AsSingle().NonLazy();
            Container.Bind<WeaponSetting>().FromInstance(weaponSetting).AsSingle().NonLazy();
            Container.Bind<WeaponView>().FromInstance(weaponView).AsSingle().NonLazy();

            Container.Bind<WeaponController>().AsSingle().NonLazy();
            Container.Bind<PlayerController>().AsSingle().NonLazy();
        }
    }
}