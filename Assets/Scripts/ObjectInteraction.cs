using UnityEngine;
using UnityEngine.UI; // или using TMPro; для TextMeshPro
using TMPro;

public class ObjectInteraction : MonoBehaviour
{
    public Text interactionText; // Перетащите сюда ваш UI текст
    // или используйте TextMeshProUGUI для TextMeshPro: public TextMeshProUGUI interactionText;

    private void Start()
    {
        interactionText.enabled = false; // Скрыть текст при старте
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Убедитесь, что у вашего игрока установлен тег "Player"
        {
            interactionText.enabled = true; // Показать текст
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionText.enabled = false; // Скрыть текст
        }
    }
}
