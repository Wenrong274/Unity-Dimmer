using UnityEngine;
using UnityEngine.UI;

namespace Dimmer
{
    public class ExampleBrightness : MonoBehaviour
    {
        [SerializeField] private float value = 0.5f;
        [SerializeField] private Text text;
        [SerializeField] private Slider slider;

        private void Awake()
        {
            slider.onValueChanged.AddListener(SetBrightness);
        }

        private void Start()
        {
            slider.value = 0.5f;
            SetBrightness(0.5f);
        }

        public void SetBrightness(float v)
        {
            value = v;
            text.text = value.ToString("0.00");
            Dimmer.SetBrightness.DoAction(value);
        }
    }
}
