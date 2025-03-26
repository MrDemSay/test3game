using UnityEngine;
using UnityEngine.UI;

public class HintManager : MonoBehaviour
{
    public GameObject hintPanel; // Ссылка на панель с подсказкой
    public Button hintButton; // Ссылка на кнопку

    private void Start()
    {
        // Убедитесь, что панель скрыта в начале
        hintPanel.SetActive(false);

        // Добавьте слушатель на кнопку
        hintButton.onClick.AddListener(ToggleHint);
    }

    private void ToggleHint()
    {
        // Переключение видимости панели подсказки
        hintPanel.SetActive(!hintPanel.activeSelf);
    }
}
