using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Loop : MonoBehaviour
{
    private void Awake()
    {
        Debug.LogError("Esta funci�n se ejecuta junto con la creaci�n del objeto.");
    }
    void Start()
    {
        Debug.LogWarning("Esta funci�n se ejecuta con el primer frame del objeto en uso.");
    }
    private void FixedUpdate()
    {
        Debug.Log("Esta funci�n se ejecuta cada 50 frames.");
    }
    void Update()
    {
        Debug.Log("Esta funci�n se ejecuta con cada frame.");
    }
}
