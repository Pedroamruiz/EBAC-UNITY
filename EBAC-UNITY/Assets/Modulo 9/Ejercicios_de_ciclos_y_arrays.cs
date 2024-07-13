using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios_de_ciclos_y_arrays : MonoBehaviour
{
    int tamaño = 5;
    private void Start()
    {
        int[] Primer_array = new int[tamaño];
        int[] Segundo_array = new int[tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            Primer_array[i] = Random.Range(1, 5);
            Debug.Log($"En la posición {i+1} del primer array se encuentra un {Primer_array[i]}");
            Segundo_array[i] = Random.Range(6, 10);
            Debug.Log($"En la posición {i+1} del segundo array se encuentra un {Segundo_array[i]}");
        }
        int[] Tercer_array = new int[tamaño];

        for(int i = 0; i < tamaño ; i++)
        {
            Tercer_array[i] = Primer_array[i] + Segundo_array[i];
            Debug.Log($"En la posición {i + 1} del tercer array se encuentra {Tercer_array[i]}");
        }

        string Oracion = "Metroid Prime 4 es real";
        string[] Oracion_Dividida = Oracion.Split(' ');
        string Oracion_Rearmada = "";
        foreach (string palabra in Oracion_Dividida)
        {
            Oracion_Rearmada += palabra + " ";
        }
        Debug.Log(Oracion_Rearmada);

        int[,] Matriz_Bidimensional =
        {
            {1,2,3},
            {4,5,6}
        };
        int[] Matriz_Unidimensional = { 1, 2, 3 };
        int[] Resultado = new int[2];
        for(int i = 0;i < 2; i++)
        {
            Resultado[i] = 0;
            for(int j = 0;j < 3; j++)
            {
                Resultado[i] += Matriz_Bidimensional[i, j] * Matriz_Unidimensional[j];
            }
        }
        Debug.Log ($"Los resultados son {Resultado[0]} y {Resultado[1]}");
    }
}