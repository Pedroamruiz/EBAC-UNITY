using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios_Estructuras : MonoBehaviour
{
    public int tamaño = 5;
    public int rangoInferior = 0;
    public int rangoSuperior = 10;

    void Start()
    {
 
        List<int> numerosAleatorios = new List<int>();
        System.Random random = new System.Random();

        for (int i = 0; i < tamaño; i++)
        {
            numerosAleatorios.Add(random.Next(rangoInferior, rangoSuperior + 1));
        }

        Debug.Log("Números aleatorios generados:");
        foreach (int numero in numerosAleatorios)
        {
            Debug.Log(numero);
        }

        OrdenarArreglo ordenarArreglo = new OrdenarArreglo();
        List<int> numerosOrdenados = ordenarArreglo.OrdenarDescendente(numerosAleatorios);

        Debug.Log("Lista de números aleatorios ordenada en orden descendente:");
        foreach (int numero in numerosOrdenados)
        {
            Debug.Log(numero);
        }

        List<string> palabras = new List<string> { "manzana", "banana", "manzana", "pera" };
        EliminadorDuplicados eliminador = new EliminadorDuplicados();
        HashSet<string> palabrasUnicas = eliminador.EliminarDuplicados(palabras);

        Debug.Log("Palabras sin duplicados:");
        foreach (string palabra in palabrasUnicas)
        {
            Debug.Log(palabra);
        }

        Stack<string> pila = new Stack<string>();
        pila.Push("uno");
        pila.Push("dos");
        pila.Push("tres");
        pila.Push("cuatro");

        ProcesarPilaYCola(pila);
    }

    public class OrdenarArreglo
    {
        public List<int> OrdenarDescendente(List<int> lista)
        {
            List<int> listaOrdenada = new List<int>(lista);
            listaOrdenada.Sort();
            listaOrdenada.Reverse();
            return listaOrdenada;
        }
    }

    public class EliminadorDuplicados
    {
        public HashSet<string> EliminarDuplicados(List<string> lista)
        {
            return new HashSet<string>(lista);
        }
    }

    void ProcesarPilaYCola(Stack<string> pila)
    {
        Debug.Log("Contenido de la pila:");
        foreach (var item in pila)
        {
            Debug.Log(item);
        }

        Queue<string> cola = new Queue<string>();

        while (pila.Count > 0)
        {
            string elemento = pila.Pop();
            cola.Enqueue(elemento);
        }

        Debug.Log("Contenido de la cola:");

        if (cola.Count > 0)
        {
            Debug.Log("Primer elemento de la cola: " + cola.Peek());
        }

        while (cola.Count > 0)
        {
            string elemento = cola.Dequeue();
            Debug.Log(elemento);
        }
    }
}