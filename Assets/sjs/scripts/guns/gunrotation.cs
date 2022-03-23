using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunrotation : MonoBehaviour
{
    private Vector3 playerScale;
    private float moveInput;
    private void Start()
    {
        playerScale = transform.root.localScale;
    }

    void Update()
    {

        if (moveInput < 0)
        {

            playerScale.x = 1;
            transform.localScale = playerScale;
        }
        else if (moveInput > 0)
        {

            playerScale.x = -1;
            transform.localScale = playerScale;
        }
    }


    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
    }
}
