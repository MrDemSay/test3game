using UnityEngine;
using UnityEngine.UI;

public class DistanceToObject : MonoBehaviour
{
    public Transform targetObject; // Объект, до которого нужно измерять расстояние
    public Text distanceText; // UI элемент для отображения расстояния
    public float d;



    void Update()
    {
    	d = (int)Vector3.Distance(targetObject.position, transform.position);
        distanceText.text = d.ToString("F1") + " m";
    }
}
