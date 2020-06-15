using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Player,CamTarget;
    
    public float RotationSpeed = 1;
    float mouseX,mouseY;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        CamControl();
    }
    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X")*RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y")*RotationSpeed;
        mouseY = Mathf.Clamp(mouseY,-35,60);

        transform.LookAt(CamTarget);

        CamTarget.rotation = Quaternion.Euler(mouseY,mouseX,0);
        Player.rotation = Quaternion.Euler(0,mouseX,0);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
