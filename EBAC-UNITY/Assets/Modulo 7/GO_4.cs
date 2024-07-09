using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_4 : MonoBehaviour
{
    public GO_1 scriptGO1;
    public GO_2 scriptGO2;
    public bool ConditionGO4;
    private void FixedUpdate()
    {
        bool EstadoGO1 = scriptGO1.ConditionGO1;
        bool EstadoGO2 = scriptGO2.ConditionGO2;
        if (EstadoGO1 || EstadoGO2)
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            ConditionGO4 = true;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            ConditionGO4 = false;
        }
    }
}