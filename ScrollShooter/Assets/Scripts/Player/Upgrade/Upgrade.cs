using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Player.Upgrade
{
    public class Upgrade : MonoBehaviour
    {
        [SerializeField] private UpgradeData data;
        [SerializeField] private Button button;
        [SerializeField] private Outline outline;
        [SerializeField] private TextMeshProUGUI text;

        private void Start()
        {
            switch (data.Rarity)
            {
                case UpgradeRarity.Common:
                    outline.effectColor = Color.green;
                    break;
                case UpgradeRarity.Rare:
                    outline.effectColor = Color.magenta;
                    break;
                case UpgradeRarity.Epic:
                    outline.effectColor = Color.red;
                    break;
                case UpgradeRarity.Legendary:
                    outline.effectColor = Color.yellow;
                    break;
            }

            text.text = $"{data.Type} {data.Value}%";

            if(data.Rarity == UpgradeRarity.Legendary)
                text.text = $"{data.Type} +{data.Value}";
            button.onClick.AddListener(Use);
        }

        private void Use()
        {
            PlayerUpgrader.OnUpgrade?.Invoke(data);
        }

        private void OnDestroy()
        {
            button.onClick.RemoveListener(Use);
        }
    }
}