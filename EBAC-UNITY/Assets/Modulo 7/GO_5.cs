using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_5 : MonoBehaviour
{
    public GO_3 scriptGO3;
    public GO_4 scriptGO4;
    public bool ConditionGO4;
    private void FixedUpdate()
    {
        bool EstadoGO1 = scriptGO3.ConditionGO3;
        bool EstadoGO2 = scriptGO4.ConditionGO4;
        if (EstadoGO1 && EstadoGO2)
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
            ConditionGO4 = true;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.grey;
            ConditionGO4 = false;
        }
    }
}