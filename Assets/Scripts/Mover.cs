using Unity.Collections;
using UnityEngine;
using Unity.Mathematics;

public class Mover : MonoBehaviour
{
    [SerializeField] float speedLevel = 0f;
    [SerializeField] float jumpLevel = 0f;
    [SerializeField] float downLevel = 0f;
    void Start()
    {

    }

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * math.pow(1.5f, speedLevel);
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") *Time.deltaTime * math.pow(1.5f, speedLevel);
        transform.Translate(xValue, yValue, zValue);
    }
}
