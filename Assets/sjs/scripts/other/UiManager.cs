using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject img;
    public List<GameObject> healthIcons;
    public playerStats Pstats;


    private void Start()
    {
        Pstats = GameObject.FindGameObjectWithTag("Player").GetComponent<playerStats>();
       
        //instantiate health icons
        for (int i = 0; i < Pstats.maxHealth; i++)
        {
          healthIcons.Add(Instantiate(img,this.transform));
            
            healthIcons[i].transform.localPosition = new Vector2(-380+i*40, 200);
        }

    }

    

    public void healthUpdate()
    {
        int i = 0;
        if (healthIcons.Count != Pstats.currentHealth)
        {
        
            foreach(GameObject healthIcon in healthIcons)
            {
                if (i + 1 > Pstats.currentHealth)
                {
                    healthIcon.GetComponent<Image>().enabled = false;
                }
                else
                {
                    healthIcon.GetComponent<Image>().enabled = true;
                }

                i++;
            }
        }
    }
}
