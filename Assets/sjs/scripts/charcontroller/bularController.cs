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
    
    
    
    private void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();
        playerScale = transform.localScale;
    }

    private void Update()
    {
        basemovement();   
    }

private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");

        if (moveInput != 0)
        {
            playerScale.x = Mathf.Abs(playerScale.x)*Mathf.Sign(moveInput);
            transform.localScale = playerScale;
        }
        
    }

    private void basemovement()
    {
        if (Input.GetButton("Jump") && RB.velocity.y == 0)
        {
            RB.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        if(RB.velocity.y == 0)
        {
            transform.Translate(moveInput * speed * Time.deltaTime, 0, 0);
        }
        else
        {
            //RB.AddForce(new Vector2(moveInput * speed*Time.deltaTime, 0), ForceMode2D.Impulse);
        }
    }

    

}
