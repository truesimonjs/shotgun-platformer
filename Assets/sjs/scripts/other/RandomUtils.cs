using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomUtils : MonoBehaviour
{

    //takes your position and the target position and returns the rotation you need to point at the target in 2d
    public float pointAt(Vector3 selfPos, Vector3 targetPos)
    {

        float triY = (targetPos.y - selfPos.y);
        float triX = (targetPos.x - selfPos.x);

        float result = 90 + (Mathf.Atan(triY / triX) * Mathf.Rad2Deg);

        if (triX > 0) result += 180;
        return result;

        
    }

    public Vector3 randomVector3(Vector3 V1,Vector3 V2)
    {
        return new Vector3(Random.Range(V1.x,V2.x),Random.Range(V1.y,V2.y),Random.Range(V1.z,V2.z));

    }
}
