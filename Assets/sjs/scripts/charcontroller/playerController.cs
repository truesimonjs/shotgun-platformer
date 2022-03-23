using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;
    private Vector3 Move;
    //input and component calls
    private CharacterController CharCtrl;
    private float moveInput;
    private void Start()
    {
        moveInput = Input.GetAxis("Horizontal");
        CharCtrl = this.GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move = new Vector3(moveInput * speed * Time.deltaTime, 0, 0);
        CharCtrl.Move(Move);
        this.transform.forward = Move;  

        
    }
}
