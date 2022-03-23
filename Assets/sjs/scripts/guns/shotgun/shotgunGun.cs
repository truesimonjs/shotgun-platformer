using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgunGun  : MonoBehaviour
{
    //things to be changed in editor
    public GameObject bullet;
     public float fireRate;
    public float pushback = 2;
    public float bulletAngle;
    public int bulletAmount;
    //private variables
    private float nextFire;
    //mouse position ingame
    private Vector3 mousepos;
    //camera
    private Camera cam;
    //the playeres rigidbody
    private GameObject Player;
    private Rigidbody2D playerRB;
    private Transform playerTrans;
    // bullet list
    private List<GameObject> bulletList = new List<GameObject>();
    

    private void Update()
    {
        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Fire();
        }
    }


    private void Fire () 
    {
                
        float angle = 0;
        if (Time.time>=nextFire)
        {
            nextFire = Time.time + fireRate;
            bulletList.Clear();
            for (int i = 0; i < bulletAmount; i++)
            {

                var newBullet = Instantiate(bullet, this.transform.position, this.transform.rotation);
                
                bulletList.Add(newBullet);
                
            }
            
            foreach(GameObject newbullet in bulletList)
            {
                int bulletnum = bulletList.IndexOf(newbullet);
                angle = bulletAngle + bulletAngle * bulletnum;
                if (bulletnum % 2!=0)
                {
                    angle= angle*-1;
                }
                
                
                newbullet.transform.Rotate(0,0,angle);
                
                
                
                

                
            }

            playerRB.AddRelativeForce(transform.up*pushback*-1, ForceMode2D.Impulse);
            


        }
    }




    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerRB = Player.GetComponent<Rigidbody2D>();
        playerTrans= Player.GetComponent<Transform>();

        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }



}
