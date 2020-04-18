using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] KeyCode MoveForward;
    [SerializeField] KeyCode MoveBackward;
    [SerializeField] KeyCode MoveLeft;
    [SerializeField] KeyCode MoveRight;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(MoveForward))
        {
            transform.position += new Vector3(0f,0f,0f) * Time.deltaTime;
        }
        if(Input.GetKey(MoveBackward))
        {
            transform.position += new Vector3(0f,0f,0f) * Time.deltaTime;
        }
        if(Input.GetKey(MoveLeft))
        {
            transform.position += new Vector3(0f,0f,0f) * Time.deltaTime;
        }
        if(Input.GetKey(MoveRight))
        {
            transform.position += new Vector3(0f,0f,0f) * Time.deltaTime;
        }
    }
}
