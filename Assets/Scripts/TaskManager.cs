using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class TaskManager : MonoBehaviour
{
    public GameObject taskPanel; // Ссылка на панель задач
    public GameObject taskPrefab; // Префаб задачи
    public Transform taskContainer; // Контейнер для задач

    private List<string> tasks = new List<string>(); // Список задач

    void Start()
    {
        // Пример добавления задач
        tasks.Add("Ремонт элелектричества.");

        
        // Отобразите задачи
        DisplayTasks();
        
        // Скрыть панель задач в начале
        taskPanel.SetActive(false);
    }

    public void ToggleTaskPanel()
    {
        // Переключение видимости панели задач
        taskPanel.SetActive(!taskPanel.activeSelf);
    }

    private void DisplayTasks()
    {
        // Очистите контейнер перед отображением
        foreach (Transform child in taskContainer)
        {
            Destroy(child.gameObject);
        }

        // Создайте элементы для каждой задачи
        foreach (var task in tasks)
        {
            GameObject taskItem = Instantiate(taskPrefab, taskContainer);
            taskItem.GetComponent<Text>().text = task; // Установите текст задачи
        }
    }
}
