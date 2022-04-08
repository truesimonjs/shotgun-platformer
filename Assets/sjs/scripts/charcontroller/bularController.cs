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
    private BoxCollider2D col;
    private LayerMask Mask;
    
    
    private void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();
        playerScale = transform.localScale;
        col = this.GetComponent<BoxCollider2D>();
        Mask = LayerMask.GetMask("Ground");

    }

    private void Update()
    {
        
    }

private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        basemovement();
        

        if (moveInput != 0)
        {
            playerScale.x = Mathf.Abs(playerScale.x)*Mathf.Sign(moveInput);
            transform.localScale = playerScale;
        }
        
    }

    private void basemovement()
    {
        


        if (Input.GetButton("Jump") && IsGrounded()     )
        {
            RB.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        if (IsGrounded())
        {
            

           
            RB.velocity = (new Vector2( moveInput * speed , RB.velocity.y));

        }
        else
        {
            
          RB.AddForce(new Vector2(moveInput * speed, 0), ForceMode2D.Force);
            

        }

    }

    public bool IsGrounded()
    {

        RaycastHit2D hit;
        hit = Physics2D.Raycast(this.transform.position, Vector2.down, (col.size.y-col.offset.y)/2,Mask);


        return hit.collider != null;
        
        





    }

}
