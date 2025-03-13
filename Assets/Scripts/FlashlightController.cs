using UnityEngine;
using UnityEngine.UI;

public class FlashlightController : MonoBehaviour
{
    public Light flashlight; // Перетащите сюда ваш источник света
    public Button flashlightButton;

    void Start()
    {
        flashlightButton.onClick.AddListener(ToggleFlashlight);
        flashlight.enabled = false; // Скрыть фонарик при старте
    }

    void ToggleFlashlight()
    {
        flashlight.enabled = !flashlight.enabled; // Переключить состояние света
    }
}
