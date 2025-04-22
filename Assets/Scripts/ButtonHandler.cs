using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ButtonHandler : MonoBehaviour
{
    
    public int buttonIndex; // Индекс этой кнопки в последовательности
    public Button button; // Ссылка на кнопку
    public Light roomLight1; // Ссылка на объект света в комнате
    public Light roomLight2; // Ссылка на объект света в комнате
    public static bool isLightOn = false;
    public static int currentStep = 1;
   

    private void Start()
    {
        button.onClick.AddListener(OnButtonClick); // Добавляем обработчик события нажатия
        roomLight1.enabled = isLightOn;
        roomLight2.enabled = isLightOn;
    }

    private void OnButtonClick()
    {   
        if (buttonIndex == currentStep)
        {      
            currentStep++;
            Debug.Log(currentStep);
            // Проверка завершения последовательности
            if (currentStep == 5) // Замените 3 на количество ваших шагов
            {
                Debug.Log("Последовательность завершена!");
                ChangeRoomLighting();
                // Здесь можно добавить логику для завершения (например, скрытие Canvas)
            }
        }
        else
        {
            Debug.Log("Неправильная кнопка! Попробуйте снова.");
            currentStep = 1; // Сбрасываем текущий шаг
        }
    }

    private void ChangeRoomLighting()
    {
        if (roomLight1 != null && roomLight1 != null)
        {
          roomLight1.enabled = !isLightOn;
          roomLight2.enabled = !isLightOn;
        }
    }
}
