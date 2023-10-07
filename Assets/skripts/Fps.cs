using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fps : MonoBehaviour
{
    public float sensitivity = 2.0f; // Fare hassasiyeti
    public float rotationSpeed = 2.0f; // Kamera dönme hızı
    public float upDownRange = 60.0f; // Yukarı ve aşağı dönme sınırları

    void Update()
    {
        // Fare ile kamerayı döndür
        float horizontalRotation = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(0, horizontalRotation, 0);

    }
}
