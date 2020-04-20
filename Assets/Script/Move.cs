using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 PlayerMovement = new Vector3 (Horizontal,0f,Vertical)*speed*Time.deltaTime;
        transform.Translate(PlayerMovement,Space.Self);
    }
}