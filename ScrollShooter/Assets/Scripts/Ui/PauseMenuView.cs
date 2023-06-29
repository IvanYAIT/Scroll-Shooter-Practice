using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class PauseMenuView : MonoBehaviour
    {
        [SerializeField] private Button mainMenuBtn;
        [SerializeField] private Button continueBtn;
        [SerializeField] private Button pauseMenuBtn;
        [SerializeField] private GameObject pauseMenuPanel;

        public Button MainMenuBtn => mainMenuBtn;
        public Button ContinueBtn => continueBtn;
        public Button PauseMenuBtn => pauseMenuBtn;
        public GameObject PauseMenuPanel => pauseMenuPanel;
    }
}