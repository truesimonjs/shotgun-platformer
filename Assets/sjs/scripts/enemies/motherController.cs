using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motherController : MonoBehaviour
{
    public int health= 5;
    public float speed = 2;
    private Transform playerT;
    public int feardist = 20;
    private void Start()
    {
        playerT = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void Update()
    {
        if (Vector3.Distance(this.transform.position, playerT.position) < feardist)
        {
            {
                if (playerT.position.x > transform.position.x)
                {
                    transform.Translate(-1 * speed * Time.deltaTime * transform.right);


                }
                else if (playerT.position.x < transform.position.x)
                {
                    transform.Translate(speed * Time.deltaTime * transform.right);
                }
            }
        }

        if (health <= 0)
        {
            Destroy(gameObject);    
        }

        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            health -= 1;
        }


    }

}
