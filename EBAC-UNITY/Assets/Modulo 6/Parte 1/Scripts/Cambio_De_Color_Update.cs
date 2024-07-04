using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_De_Color_Update : MonoBehaviour
{
    void Update()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}