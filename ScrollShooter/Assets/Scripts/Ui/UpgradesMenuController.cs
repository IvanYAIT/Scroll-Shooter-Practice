using Core;
using UnityEngine;
using Zenject;

namespace UI
{
    public class UpgradesMenuController
    {
        private UpgradesMenuView _menuView;

        [Inject]
        public UpgradesMenuController(UpgradesMenuView menuView)
        {
            _menuView = menuView;
            _menuView.UpgradeMenuBtn.onClick.AddListener(OpenMenu);
            _menuView.CloseBtn.onClick.AddListener(CloseMenu);

            if (LevelData.Instance().ChoosenMode == ModeType.Test)
                _menuView.UpgradeMenuBtn.gameObject.SetActive(true);
            else
                _menuView.UpgradeMenuBtn.gameObject.SetActive(false);
        }

        private void OpenMenu()
        {
            _menuView.UpgradeMenuPanel.SetActive(true);
            Game.OnPause?.Invoke(true);
        }

        private void CloseMenu()
        {
            _menuView.UpgradeMenuPanel.SetActive(false);
            Game.OnPause?.Invoke(false);
        }
    }
}