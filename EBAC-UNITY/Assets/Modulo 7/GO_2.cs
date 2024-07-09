using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2 : MonoBehaviour
{
    public bool ConditionGO2 = true;
    private void FixedUpdate()
    {
        if (ConditionGO2)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
        ConditionGO2 = !ConditionGO2;
    }
}