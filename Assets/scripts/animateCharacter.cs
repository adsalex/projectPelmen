using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateCharacter : MonoBehaviour
{

    [SerializeField]
    Animator animator_jump;
    [SerializeField]
    Animator animator_move;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical") )
        {
            animator_move.Play("movement");

        }
        else { animator_move.SetBool("playTrig", false); }
        if (Input.GetButton("Jump"))
        {
            animator_jump.Play("Jump");
        }
    }
    
}
