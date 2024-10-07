using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	[SerializeField]
	float playerMoveSpeed = 5f;
    [SerializeField]
    float playerRotationSpeed = 45f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () 
    {
        rotatePlayer();
	}

    private void FixedUpdate()
    {
        movePlayer();
    }
    private void rotatePlayer()
    {
        rb.transform.Rotate
            (
            new Vector3
            (
             0, Input.GetAxis("Mouse X"), 0
            ) * Time.deltaTime * playerRotationSpeed
            );
    }

    void movePlayer() 
    {
        
        Vector3 worldPosition = transform.TransformDirection(new Vector3
            (
            Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")
            ) 
            );

        rb.MovePosition(transform.position+
            worldPosition * Time.fixedDeltaTime * playerMoveSpeed);

        
    }
    
}
