using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private Slider healthSlider;
        [SerializeField] private TextMeshProUGUI healthText;

        public Slider HealthSlider => healthSlider;
        public TextMeshProUGUI HealthText => healthText;
    }
}