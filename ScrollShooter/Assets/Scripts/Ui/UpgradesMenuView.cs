using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UpgradesMenuView : MonoBehaviour
    {
        [SerializeField] private Button upgradeMenuBtn; 
        [SerializeField] private Button closeBtn;
        [SerializeField] private GameObject upgradeMenuPanel;

        public Button UpgradeMenuBtn => upgradeMenuBtn;
        public Button CloseBtn => closeBtn;
        public GameObject UpgradeMenuPanel => upgradeMenuPanel;
    }
}