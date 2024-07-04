using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creacion_De_Objeto_OnDisable : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    private void OnDisable()
    {
        GameObject instantiatedPrefab = Instantiate(prefabToInstantiate);
        instantiatedPrefab.transform.position = new Vector3(0, 4, 0);
        Destroy(instantiatedPrefab, 10f);
    }
}