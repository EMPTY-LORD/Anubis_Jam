using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    public Transform character; // Dışarıdan karakter nesnesini atayacağınız transform
    public Transform cameraTransform; // Dışarıdan kamera nesnesini atayacağınız transform
    public float moveSpeed = 5f;
    public float sensitivity = 2f;

    private float verticalRotation = 0f;
    private float upDownRange = 60f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Kamera rotasyonu
        float horizontalRotation = Input.GetAxis("Mouse X") * sensitivity;
        character.Rotate(0f, horizontalRotation, 0f);

        verticalRotation -= Input.GetAxis("Mouse Y") * sensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        cameraTransform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // Karakter hareketi
        float forwardSpeed = Input.GetAxis("Vertical") * moveSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * moveSpeed;
        float verticalSpeed = 0f;

        if (Input.GetKey(KeyCode.Space))
        {
            verticalSpeed = moveSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            verticalSpeed = -moveSpeed;
        }

        Vector3 moveDirection = character.forward * forwardSpeed + character.right * sideSpeed + character.up * verticalSpeed;
        character.GetComponent<CharacterController>().Move(moveDirection * Time.deltaTime);

        // Cursor kontrolü
        if (Cursor.lockState != CursorLockMode.Locked)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}