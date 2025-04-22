using UnityEngine;
using UnityEngine.UI;

public class FlashlightController : MonoBehaviour
{
    public Light flashlight; // Перетащите сюда ваш источник света
    public Button flashlightButton;
    public Light l1;
    public Light l2;

    void Start()
    {
        flashlightButton.onClick.AddListener(ToggleFlashlight);
        flashlight.enabled = false; // Скрыть фонарик при старте
        l1.enabled = false;
        l2.enabled = false;
    }

    void ToggleFlashlight()
    {
        flashlight.enabled = !flashlight.enabled; // Переключить состояние света
    }


}
