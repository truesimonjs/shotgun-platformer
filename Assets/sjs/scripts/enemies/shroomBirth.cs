using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shroomBirth : MonoBehaviour
{
    private float birthTime;
    public float motherCD= 2;
    public GameObject childPrefab;
    int childCount = 2;
    private List<GameObject> Children = new List<GameObject>();
    private void Start()
    {
        for (int i = 0; i < childCount; i++)
        {
            Children.Add(Instantiate(childPrefab, this.transform.position, Quaternion.identity));
           /* foreach(GameObject child in Children)
            {
                
                
            } */
        }
    }
    private void Update()
    {
        if (Time.time>birthTime)
        {

            foreach(GameObject child in Children)
            {
                if (child.activeSelf==false) {
                    Transform childT = child.GetComponent<Transform>();
                    childT.position = this.transform.position;
                    child.SetActive(true);
                    break;
                }
                
            }

            birthTime = Time.time + motherCD;
        }
        
    }

}
