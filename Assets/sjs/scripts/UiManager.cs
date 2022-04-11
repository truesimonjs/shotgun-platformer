using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject img;
    public List<GameObject> health;
    public int maxHealth = 3;
   

    private void Start()
    {
        for (int i = 0; i < maxHealth; i++)
        {
          health.Add(Instantiate(img,this.transform));
            
            health[i].transform.localPosition = new Vector2(-380+i*40, 200);
        }
    }

}
