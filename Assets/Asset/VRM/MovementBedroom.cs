using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementBedroom : MonoBehaviour
{
    public Animator anim ;
    public Rigidbody rbody;

    private float Horizontal;
    private float Vertical;

    public int speed;
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        anim.SetFloat("Horizontal", Horizontal);
        anim.SetFloat("Vertical", Vertical);

       

        PlayerMovement();
        
    }

    void PlayerMovement()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
 
        Vector3 PlayerMovement = new Vector3(0f, 0f, Vertical) * speed * Time.deltaTime;
        PlayerMovement = transform.TransformDirection(PlayerMovement);
        transform.Rotate(0, Horizontal, 0);
        transform.Translate(PlayerMovement, Space.World);
        


    }

    void Start()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
    }


    
   }
    
