using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    [SerializeField]
    float jumpForce = 50;
    bool canJump = true;
    Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(canJump && Input.GetButton("Jump")) 
        { 
            rigidbody.AddForce(Vector3.up*jumpForce); 
            canJump = false;
        }
    }
    private void OnCollisionEnter(Collision  collision)
    {
        //collision.GetContact(0);
        //collision.collider.transform.position.y
        for( int contact = 0;contact<collision.contactCount ;contact++) 
        {
            if (collision.GetContact(contact).point.y < transform.position.y)
            {
                canJump = true;
                break;
            }
        }
        
    }
}
