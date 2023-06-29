using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Core
{
    public class Game
    {
        private const int MAIN_MENU_SCENE_INDEX = 0;
        private const int GAMEPLAY_SCENE_INDEX = 1;

        public static Action OnLose;
        public static Action OnStart;
        public static Action<bool> OnPause;

        public Game()
        {
            OnLose += Lose;
            OnPause += Pause;
            OnStart += Start;
        }

        private void Start()
        {
            SceneManager.LoadScene(GAMEPLAY_SCENE_INDEX);
            OnLose -= Lose;
            OnPause -= Pause;
            OnStart -= Start;
        }

        private void Pause(bool isPause)
        {
            if (isPause)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;
        }

        private void Lose()
        {
            SceneManager.LoadScene(MAIN_MENU_SCENE_INDEX);
            OnLose -= Lose;
            OnPause -= Pause;
            OnStart -= Start;
        }
    }
}