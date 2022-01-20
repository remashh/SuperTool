using UnityEngine;
using Playtika;

public class ExampleClass : MonoBehaviour
{
    private float movemetSpeed = 5f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.AddXPosition(horizontalInput * movemetSpeed * Time.deltaTime);
    }
}