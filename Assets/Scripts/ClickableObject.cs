using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public GameObject objectToSpawn; // Объект, который будет спавниться
    private GameObject spawnedObject; // Ссылка на созданный объект
    public GameObject otherObject;



    void Update()
    {
        // Проверяем, есть ли касание
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began) // Если началась новая касание
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                // Проверяем, попали ли мы по объекту
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform == transform) // Если кликнули именно на этот объект
                    {
                        OnClick();
                    }
                }
            }
        }

        // Если объект уже существует, обновляем его позицию
        if (spawnedObject != null)
        {
            PositionObject();
        }
    }

    private void OnClick()
    {
        if (spawnedObject == null)
        {
            // Создаем объект перед камерой
            spawnedObject = Instantiate(objectToSpawn);
            PositionObject();
            otherObject.SetActive(!otherObject.activeSelf);
        }
        else
        {
            // Переключаем видимость объекта
            spawnedObject.SetActive(!spawnedObject.activeSelf);
            otherObject.SetActive(!otherObject.activeSelf);
        }
    }

    private void PositionObject()
    {
        if (spawnedObject != null)
        {
            // Позиция перед камерой
            Vector3 position = Camera.main.transform.position + Camera.main.transform.forward * 2f; // 2f - расстояние от камеры
            spawnedObject.transform.position = position;
            spawnedObject.transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward); // Поворачиваем объект к камере
        }
    }
}
