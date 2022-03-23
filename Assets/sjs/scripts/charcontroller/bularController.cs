using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bularController : MonoBehaviour
{
    private float moveInput;
    public float speed = 5;
    private Rigidbody2D RB;
    public float jumpForce;
    private Vector3 playerScale;
    private bool canMove = true;
    //slide
    public float slideMultiplier = 5;
    public float slideCD = 1;
    private float slideTimer;
    
    private void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();
        playerScale = transform.localScale;
    }

    private void Update()
    {
        basemovement();

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            slide();
        }

        
    }







    private void basemovement()
    {
        if (Input.GetButton("Jump") && RB.velocity.y == 0)
        {
            RB.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        if (moveInput < 0)
        {
            
            playerScale.x = Mathf.Abs(playerScale.x);
            transform.localScale = playerScale;
        }
        else if (moveInput > 0)
        {
            
            playerScale.x = Mathf.Abs(playerScale.x)-1;
            transform.localScale = playerScale;
        }
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");

        if (canMove)
        {
            
            transform.Translate(moveInput * speed*Time.deltaTime, 0,0);
        } else if (slideTimer<Time.time)
        {
            canMove = true;
        }

    }


    private void slide()
    {
        if (canMove)
        {
            canMove = false;
            RB.AddForce(new Vector2(speed * slideMultiplier, 0) * playerScale * -1, ForceMode2D.Impulse);
            slideTimer = Time.time + slideCD;
        }
    }

    
}
