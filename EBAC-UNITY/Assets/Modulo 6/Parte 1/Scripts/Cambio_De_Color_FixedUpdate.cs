using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_De_Color_FixedUpdate : MonoBehaviour
{
    Renderer color_aleatorio;
    private void FixedUpdate()
    {
        color_aleatorio = GetComponent<Renderer>();
        Color RGB = new Color(Random.value, Random.value, Random.value);
        color_aleatorio.material.color = RGB;
        Debug.Log("Cambia de color al crearse");
    }
}