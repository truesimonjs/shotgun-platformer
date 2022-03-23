using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vortexManager : MonoBehaviour
{
    public List<GameObject> vortexTargets = new List<GameObject>();
    public float vortexPower = 5;
    public float timer= 1;
    public void spawnVortex(Vector2 spawnPoint)
    {
        
      foreach (GameObject vortextarget in vortexTargets)
        {
            vortextarget.GetComponent<vortexAffected>().vortexHit(spawnPoint, timer, vortexPower);
        }
    }



    
}
