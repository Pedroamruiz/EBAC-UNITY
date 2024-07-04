using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creacion_De_Objeto_OnEnable : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    private void OnEnable()
    {
        GameObject instantiatedPrefab = Instantiate(prefabToInstantiate);
        instantiatedPrefab.transform.position = new Vector3(0, 6, 0);
        Destroy(instantiatedPrefab,10f);
    }
}