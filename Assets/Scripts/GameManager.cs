using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int playerScore; // Пример переменной

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Не уничтожать объект при загрузке новой сцены
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
