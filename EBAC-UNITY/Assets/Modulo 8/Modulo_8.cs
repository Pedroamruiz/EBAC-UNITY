using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Modulo_8 : MonoBehaviour
{
    int Contador_De_Enteros = 0;
    float Contador_De_Decimales = 0.1f;
    private void Update()
    {
        Contador_De_Enteros++;
        Debug.Log($"Iteraci�n de la variables INT no. {Contador_De_Enteros}");
    }

    private void FixedUpdate()
    {
        Contador_De_Decimales *= 2;
        Debug.Log($"Iteraci�n de la variable FLOAT no.{Contador_De_Decimales}");
    }
    float Primer_Flotante = 0.375f;
    float Segundo_Flotante = 0.625f;
    private void Start()
    {
        float Resultado_Flotante = Primer_Flotante + Segundo_Flotante;
        int Resultado_Entero = (int)Resultado_Flotante;
        int Modulo = Resultado_Entero % 2;
        string Caracteristica_Del_Numero;
        if (Modulo == 0)
        {
            Caracteristica_Del_Numero = "Par";
        }
        else
        {
            Caracteristica_Del_Numero = "Impar";
        }
        Debug.Log($"El primer n�mero es {Primer_Flotante}, el segundo n�mero es {Segundo_Flotante}. la suma de ambos es {Resultado_Entero}, el cu�l es {Caracteristica_Del_Numero}");
        switch (Caracteristica_Del_Numero)
        {
            case "Par":
                GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case "Impar":
                GetComponent<MeshRenderer>().material.color = Color.red;
                break;
        }
        float Numero_A_Convertir = 0.1234f;
        string Float_A_String = Numero_A_Convertir.ToString();
        Debug.Log($"El n�mero convertido a String es {Numero_A_Convertir}\n El primer decimal del String es {Float_A_String[2]}, el segundo es {Float_A_String[3]}, el tercero es {Float_A_String[4]} y el cuarto es {Float_A_String[5]}");

        string Nombre_y_apellido = "Pedro Marquina Ruiz";
        string Primer_Nombre = Nombre_y_apellido.Substring(0, 5);
        string Primer_Apelldio = Nombre_y_apellido.Substring(6, 8);
        string Segundo_Apellido = Nombre_y_apellido.Substring(15);
        Debug.Log($"Mi primer nombre es {Primer_Nombre}, mis apellidos son {Primer_Apelldio} {Segundo_Apellido}");
        string[] Nombre_En_Caracteres = Nombre_y_apellido.Split(' ');
        foreach (string parte in Nombre_En_Caracteres)
        {
            Debug.Log(parte);
        }
        string Primer_Numero = "1234";
        string Segundo_Numero = "4321";
        int Numero_1, numero_2;
        int.TryParse(Primer_Numero, out Numero_1);
        int.TryParse(Segundo_Numero, out numero_2);
        int suma = Numero_1 + numero_2;
        Debug.Log($"Los n�meros a convertir en INT son {Primer_Numero} y {Segundo_Numero}, la suma de ambos es {suma}");

        string oracion = "M�dulo 8";
        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(oracion[i]);
            }
        }
        string Oracion_Base = "12345Modulo 8";
        string Oracion_Recortada = Oracion_Base.Substring(5);
        Debug.Log($"la oraci�n original es {Oracion_Base}, y quitando los primeros 5 caracteres queda as� {Oracion_Recortada}");
    }
}