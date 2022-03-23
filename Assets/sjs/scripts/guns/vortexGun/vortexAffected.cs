using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vortexAffected : MonoBehaviour
{
    private vortexManager vortexM;
    private float vortexpower;
    private Rigidbody2D RB;
    private Vector2 vortexPoint;
    private bool vortexActive = false;
    private float vortexEnd;
    private void Awake()
    {
        RB = this.transform.root.gameObject.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        vortexM = GameObject.FindGameObjectWithTag("gameManager").GetComponent<vortexManager>();
        vortexM.vortexTargets.Add(gameObject);


    }

    public void vortexHit(Vector2 targetPos, float timer, float vortexP)
    {
        this.transform.eulerAngles = new Vector3(0, 0, pointAt(this.transform.position, targetPos));
        vortexpower = vortexM.vortexPower;

        RB.AddRelativeForce(transform.up * vortexpower, ForceMode2D.Impulse);
        vortexPoint = targetPos;
        vortexActive = true;
        vortexpower = vortexP;
        vortexEnd = Time.time + timer;
    } 




    private void Update()
    {
        if (vortexActive == true)
        {
            this.transform.eulerAngles = new Vector3(0, 0, pointAt(this.transform.position,vortexPoint));
            RB.velocity=(transform.up * vortexpower);
            if (Time.time > vortexEnd)
            {
                vortexActive = false;
                //RB.velocity = new Vector2(0,0);
            }
        }
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
