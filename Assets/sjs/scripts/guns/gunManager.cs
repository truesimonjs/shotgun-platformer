using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunManager : MonoBehaviour
{
   public List <GameObject> weapList;
    public int currentWeap = 0;

    private void Start()
    {
        swapWeap();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            currentWeap -= 1;
            swapWeap();
        } else if (Input.GetKeyDown(KeyCode.E))
        {
            currentWeap += 1;
            swapWeap();
        }
    }

    private void swapWeap()
    {
        if (currentWeap < 0)
        {
            currentWeap = 0;
            

        }
        else if (currentWeap>weapList.Count-1)
        {
            currentWeap = weapList.Count - 1;
        }
        foreach (GameObject weapon in weapList)
        {
            if (weapList.IndexOf(weapon)==currentWeap)
            {
                weapon.gameObject.SetActive(true);
            }else
            {
                weapon.gameObject.SetActive(false);
            }
        }

    }


}
