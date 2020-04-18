using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 Offset;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + Offset;

        transform.Rotate(0,speed * Time.deltaTime,0);
    }
}
