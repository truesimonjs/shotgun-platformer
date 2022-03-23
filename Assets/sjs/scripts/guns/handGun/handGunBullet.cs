using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handGunBullet : MonoBehaviour
{
    public float bulletSpeed = 2;
    public List<string> tagsToKill;
    private void Update()
    {
        transform.Translate(0, bulletSpeed*Time.deltaTime,0);

       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (tagsToKill.Contains(other.tag))
        {
            Destroy(other.gameObject);
        }
    }
}
