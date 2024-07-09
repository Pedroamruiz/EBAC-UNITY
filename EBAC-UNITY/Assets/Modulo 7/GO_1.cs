using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_1 : MonoBehaviour
{
    public bool ConditionGO1 = true;
    private void FixedUpdate()
    {
        if (ConditionGO1)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
        ConditionGO1 = !ConditionGO1;
    }
}