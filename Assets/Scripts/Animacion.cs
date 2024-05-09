using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion : MonoBehaviour
     
{
    Animator animator;
    public bool isWalking;
    public bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed =  Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
        bool jumpPressed = Input.GetKey(KeyCode.Space);

        if (forwardPressed)
        {
            animator.SetBool("isWalking", true);
            isWalking = true;
        }
        else
        {
            animator.SetBool("isWalking", false);
            isWalking = false;
        }

        //Para activar la animación de salto
        if (jumpPressed)
        {
            animator.SetBool("isJumping", true);
            isJumping = true;
        }
        if (!jumpPressed)
        {
            animator.SetBool("isJumping", false);
            isJumping = false;
        }

    }
}
