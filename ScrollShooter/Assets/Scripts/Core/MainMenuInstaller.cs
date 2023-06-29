using UnityEngine;
using Zenject;
using UI;

namespace Core
{
    public class MainMenuInstaller : MonoInstaller
    {
        [SerializeField] private PrepareMenuView prepareMenuView;

        public override void InstallBindings()
        {
            Container.Bind<PrepareMenuView>().FromInstance(prepareMenuView).AsSingle().NonLazy();
            Container.Bind<PrepareMenuController>().AsSingle().NonLazy();
        }
    }
}