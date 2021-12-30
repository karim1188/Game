using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
  

    

 public float moveSpeed;
    public float jumpHeight;
    public bool isFacingRight;
    public KeyCode Spacebar;
    public KeyCode L;
    public KeyCode R;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public bool grounded;
    private Animator anim;
    void Start()
    {

        isFacingRight = true;
        anim = GetComponent<Animator>();

    }


   
        
}
    
