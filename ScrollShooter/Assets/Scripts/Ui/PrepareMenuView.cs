using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class PrepareMenuView : MonoBehaviour
    {
        [SerializeField] private Button swordBtn;
        [SerializeField] private Button weapon2Btn;
        [SerializeField] private Button weapon3Btn;
        [SerializeField] private Button weapon4Btn;
        [SerializeField] private Button weapon5Btn;
        [SerializeField] private Button normalBtn;
        [SerializeField] private Button testBtn;
        [SerializeField] private Button playBtn;
        [SerializeField] private Image swordImg;
        [SerializeField] private Image weapon2Img;
        [SerializeField] private Image weapon3Img;
        [SerializeField] private Image weapon4Img;
        [SerializeField] private Image weapon5Img;
        [SerializeField] private Image normalImg;
        [SerializeField] private Image testImg;

        public Button SwordBtn => swordBtn;
        public Button Weapon2Btn => weapon2Btn;
        public Button Weapon3Btn => weapon3Btn;
        public Button Weapon4Btn => weapon4Btn;
        public Button Weapon5Btn => weapon5Btn;
        public Button NormalBtn => normalBtn;
        public Button TestBtn => testBtn;
        public Button PlayBtn => playBtn;
        public Image SwordImg => swordImg;
        public Image Weapon2Img => weapon2Img;
        public Image Weapon3Img => weapon3Img;
        public Image Weapon4Img => weapon4Img;
        public Image Weapon5Img => weapon5Img;
        public Image NormalImg => normalImg;
        public Image TestImg => testImg;
    }
}