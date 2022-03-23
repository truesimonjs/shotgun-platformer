using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgunBullet : MonoBehaviour
{
    private Transform Ptransform;
    public float bulletSpeed = 2;
    public List<string> tagsToKill;
    public int killDistance = 20;

    private void Start()
    {
        
        Ptransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        transform.Translate(0, bulletSpeed*Time.deltaTime,0);
        if (killDistance<Vector2.Distance(transform.position, Ptransform.position))
        {
            Destroy(gameObject);
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (tagsToKill.Contains(other.tag))
        {
            Destroy(other.gameObject);
        }
    }
}
