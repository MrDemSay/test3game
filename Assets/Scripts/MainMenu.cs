using UnityEngine;
using UnityEngine.SceneManagement; // Не забудьте добавить этот using!

public class MainMenu : MonoBehaviour
{
    // Метод для загрузки первой игровой сцены
    public void PlayGame1()
    {
        SceneManager.LoadScene("FirstScene");
    }

    // Метод для загрузки второй игровой сцены
    public void PlayGame2()
    {
        SceneManager.LoadScene("BrightDay");
    }

    public void BackToMenu()
	{
	    SceneManager.LoadScene("MainMenu");
	}

}
