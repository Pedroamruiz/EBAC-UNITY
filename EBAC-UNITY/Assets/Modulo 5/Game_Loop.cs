using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Loop : MonoBehaviour
{
    private void Awake()
    {
        Debug.LogError("Esta función se ejecuta junto con la creación del objeto.");
    }
    void Start()
    {
        Debug.LogWarning("Esta función se ejecuta con el primer frame del objeto en uso.");
    }
    private void FixedUpdate()
    {
        Debug.Log("Esta función se ejecuta cada 50 frames.");
    }
    void Update()
    {
        Debug.Log("Esta función se ejecuta con cada frame.");
    }
}
