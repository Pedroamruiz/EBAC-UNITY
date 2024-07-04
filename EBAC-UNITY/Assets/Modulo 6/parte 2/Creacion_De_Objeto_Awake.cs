using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creacion_De_Objeto_Awake : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    private void Awake()
    {
        GameObject instantiatedPrefab = Instantiate(prefabToInstantiate);
        instantiatedPrefab.transform.position = new Vector3(0, 2, 0);
    }
}