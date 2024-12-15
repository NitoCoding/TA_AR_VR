using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float speed = 100.0f;
    public bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
    }

    public void ToggleRotation()
    {
        isRotating = !isRotating;
    }
}
