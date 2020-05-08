using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator anim;
    public Rigidbody rbody;

    private float Horizontal;
    private float Vertical;

    public float speed;

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
        Vector3 PlayerMovement = new Vector3 (Horizontal,0f,Vertical)*speed*Time.deltaTime;
        transform.Translate(PlayerMovement,Space.Self);
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
    }
}
