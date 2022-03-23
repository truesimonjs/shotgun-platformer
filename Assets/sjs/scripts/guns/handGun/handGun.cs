using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handGun : MonoBehaviour
{
    public GameObject bullet;
    public float fireRate;
    private float nextFire;
    private Vector3 mousepos;
    private Camera cam;


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
        if (Time.time>=nextFire)
        {
            Instantiate(bullet, this.transform.position, this.transform.rotation);
            nextFire = Time.time + fireRate;
        }
    }

    private void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }






}
