using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class smallEnemy : MonoBehaviour
{
    public float speed;
    private Transform playerT;
    private void Start()
    {
        playerT = GameObject.FindGameObjectWithTag("Player").transform;


    }

    private void Update()
    {
        if (playerT.position.x<transform.position.x)
        {
            transform.Translate(transform.right*speed*Time.deltaTime*-1);

            
        }else if (playerT.position.x > transform.position.x)
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            gameObject.SetActive(false);
        } else 
        {
            IDamageable<int, float> opponent = other.gameObject.GetComponent<IDamageable<int, float>>();
           if(opponent != null)
            {
                opponent.changeHealth(-1, this.transform.position.x);
            }
            

        }
    }
    
}
