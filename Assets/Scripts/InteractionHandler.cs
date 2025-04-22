using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    public GameObject canvasMain; // Ссылка на Canvas с изображением и кнопками
    public GameObject canvasElectro; // Ссылка на Canvas с изображением и кнопками
    public GameObject canvasChem; // Ссылка на Canvas с изображением и кнопками

    private void Start()
    {
        canvasElectro.SetActive(false); // Скрываем Canvas в начале
        canvasChem.SetActive(false); // Скрываем Canvas в начале
    }

    private void OnMouseDown() // Метод вызывается при нажатии на объект
    {
        ShowCanvasElectro();
    }

    private void ShowCanvasElectro()
    {
        canvasElectro.SetActive(true); // Показываем Canvas
        canvasMain.SetActive(false); // Показываем Canvas
        canvasChem.SetActive(false); // Показываем Canvas
        
    }

    public void HideCanvas()
    {
        if (canvasElectro != null)
        {
            canvasElectro.SetActive(false);
            canvasMain.SetActive(true);
            canvasChem.SetActive(false);
        }
    }
}
