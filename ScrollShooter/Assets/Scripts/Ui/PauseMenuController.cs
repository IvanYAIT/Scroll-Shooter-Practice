using Core;
using Zenject;

namespace UI
{
    public class PauseMenuController
    {
        private PauseMenuView _menuView;

        [Inject]
        public PauseMenuController(PauseMenuView menuView)
        {
            _menuView = menuView;
            _menuView.MainMenuBtn.onClick.AddListener(LeaveToMainMenu);
            _menuView.PauseMenuBtn.onClick.AddListener(OpenMenu);
            _menuView.ContinueBtn.onClick.AddListener(CloseMenu);
        }

        private void OpenMenu()
        {
            _menuView.PauseMenuPanel.SetActive(true);
            Game.OnPause?.Invoke(true);
        }

        private void CloseMenu()
        {
            _menuView.PauseMenuPanel.SetActive(false);
            Game.OnPause?.Invoke(false);
        }

        private void LeaveToMainMenu()
        {
            _menuView.MainMenuBtn.onClick.RemoveListener(LeaveToMainMenu);
            _menuView.PauseMenuBtn.onClick.RemoveListener(OpenMenu);
            _menuView.ContinueBtn.onClick.RemoveListener(CloseMenu);
            Game.OnPause?.Invoke(false);
            Game.OnLose?.Invoke();
        }
    }
}