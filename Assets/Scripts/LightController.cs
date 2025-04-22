using UnityEngine;

public class LightController : MonoBehaviour
{
    public static Light sceneLight; // Ссылка на свет в сцене
    public static bool isLightOn = false; // Статическая переменная для хранения состояния света

    private void Start()
    {
        // Устанавливаем состояние света при загрузке сцены
        if (sceneLight != null)
        {
            sceneLight.enabled = isLightOn; // Включаем или выключаем свет в зависимости от состояния
        }
    }

    public void ToggleLight()
    {
        isLightOn = !isLightOn; // Меняем состояние света
        if (sceneLight != null)
        {
            sceneLight.enabled = isLightOn; // Включаем или выключаем свет
        }
    }
}
