using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    [SerializeField] int speed;
    int rotation = 0;
    

    void Update() 
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0,0,-speed);
            if(rotation != 180)
            {
                transform.rotation = Quaternion.Euler(0,180,0);
                rotation = 180;
            }
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(speed,0,0);
            if(rotation != 90)
            {
                transform.rotation = Quaternion.Euler(0,90,0);
                rotation = 90;
            }
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0,0,speed);
            if(rotation != 0)
            {
                transform.rotation = Quaternion.Euler(0,0,0);
                rotation = 0;
            }
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(-speed,0,0);
            if(rotation != -90)
            {
                transform.rotation = Quaternion.Euler(0,-90,0);
                rotation = -90;
            }
        }
    }
}
