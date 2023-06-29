using Core;
using Player.Weapon;
using UnityEngine;
using Zenject;

namespace UI
{
    public class PrepareMenuController
    {
        private PrepareMenuView _menuView;

        [Inject]
        public PrepareMenuController(PrepareMenuView menuView)
        {
            _menuView = menuView;
            _menuView.NormalBtn.onClick.AddListener(SetNormalMode);
            _menuView.TestBtn.onClick.AddListener(SetTestMode);
            _menuView.SwordBtn.onClick.AddListener(SetSword);
            _menuView.Weapon2Btn.onClick.AddListener(SetWeapon2);
            _menuView.Weapon3Btn.onClick.AddListener(SetWeapon3);
            _menuView.Weapon4Btn.onClick.AddListener(SetWeapon4);
            _menuView.Weapon5Btn.onClick.AddListener(SetWeapon5);
            _menuView.PlayBtn.onClick.AddListener(Play);
            SetNormalMode();
            SetSword();
        }

        private void Play()
        {
            _menuView.NormalBtn.onClick.RemoveListener(SetNormalMode);
            _menuView.TestBtn.onClick.RemoveListener(SetTestMode);
            _menuView.SwordBtn.onClick.RemoveListener(SetSword);
            _menuView.Weapon2Btn.onClick.RemoveListener(SetWeapon2);
            _menuView.Weapon3Btn.onClick.RemoveListener(SetWeapon3);
            _menuView.Weapon4Btn.onClick.RemoveListener(SetWeapon4);
            _menuView.Weapon5Btn.onClick.RemoveListener(SetWeapon5);
            _menuView.PlayBtn.onClick.RemoveListener(Play);
            Game.OnStart?.Invoke();
        }

        private void SetNormalMode()
        {
            ResetModeBtnColor();
            _menuView.NormalImg.color = new Color(255, 255, 255, 1f);
            LevelData.Instance().ChoosenMode = ModeType.Normal;
        }

        private void SetTestMode()
        {
            ResetModeBtnColor();
            _menuView.TestImg.color = new Color(255, 255, 255, 1f);
            LevelData.Instance().ChoosenMode = ModeType.Test;
        }

        private void ResetModeBtnColor()
        {
            _menuView.NormalImg.color = new Color(255, 255, 255, 0.5f);
            _menuView.TestImg.color = new Color(255, 255, 255, 0.5f);
        }

        private void SetSword()
        {
            ResetWeaponBtnColor();
            _menuView.SwordImg.color = new Color(255, 255, 255, 1);
            LevelData.Instance().ChoosenWeapon = WeaponType.Sword;
        }
        private void SetWeapon2()
        {
            ResetWeaponBtnColor();
            _menuView.Weapon2Img.color = new Color(255, 255, 255, 1);
            LevelData.Instance().ChoosenWeapon = WeaponType.Sword;
        }
        private void SetWeapon3()
        {
            ResetWeaponBtnColor();
            _menuView.Weapon3Img.color = new Color(255, 255, 255, 1);
            LevelData.Instance().ChoosenWeapon = WeaponType.Sword;
        }
        private void SetWeapon4()
        {
            ResetWeaponBtnColor();
            _menuView.Weapon4Img.color = new Color(255, 255, 255, 1);
            LevelData.Instance().ChoosenWeapon = WeaponType.Sword;
        }
        private void SetWeapon5()
        {
            ResetWeaponBtnColor();
            _menuView.Weapon5Img.color = new Color(255, 255, 255, 1);
            LevelData.Instance().ChoosenWeapon = WeaponType.Sword;
        }

        private void ResetWeaponBtnColor()
        {
            _menuView.SwordImg.color = new Color(255, 255, 255, 0.5f);
            _menuView.Weapon2Img.color = new Color(255, 255, 255, 0.5f);
            _menuView.Weapon3Img.color = new Color(255, 255, 255, 0.5f);
            _menuView.Weapon4Img.color = new Color(255, 255, 255, 0.5f);
            _menuView.Weapon5Img.color = new Color(255, 255, 255, 0.5f);
        }
    }
}