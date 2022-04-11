using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armRotation : MonoBehaviour
{
    public Camera cam;
    public Vector3 mousepos;

    private void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    private void Update()
    {
        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        this.transform.rotation= Quaternion.Euler(0,0,pointAt(this.transform.position,mousepos));

        

    }



    public float pointAt(Vector3 selfPos, Vector3 targetPos)
    {

        float triY = (targetPos.y - selfPos.y);
        float triX = (targetPos.x - selfPos.x);

        float result = 90 + (Mathf.Atan(triY / triX) * Mathf.Rad2Deg);

        if (triX > 0) result += 180;
        return result;
    }
}
