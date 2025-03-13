using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Имя сцены, на которую нужно перейти
    public string sceneToLoad;

    // Метод вызывается при нажатии на объект
    private void OnMouseDown()
    {
        SwitchScene(sceneToLoad);
    }

    // Метод вызывается при нажатии на кнопку
    public void OnButtonClick()
    {
        SwitchScene(sceneToLoad);
    }

    // Метод для перехода на другую сцену
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
