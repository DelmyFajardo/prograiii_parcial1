using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Pila
{
    private int[] elementos;
    private int tope;
    public Pila(int tamaño)
    {
        elementos = new int[tamaño];
        tope = -1;
    }
    //Metodo para sacar un elemento de la pila
    public void Push(int elemento)
    {
        if (tope < elementos.Length - 1 )
        {
            elementos[++tope] = elemento;
        }
        else
        {
            Console.WriteLine("Pila llena");
        }
    }
    public int Pull( )
    {
        if (tope == -1)
        {
            Console.WriteLine("Pila vacia");
        }
        else
        {
            return -1;
        } 
    }

    //Metodo para limpiar toda la pila 
    public void Clear()
    {
        tope = -1;
        Console.WriteLine("Pila vacia");
    }

    public void Mostrar()
    {
        if (tope == -1)
        {
            Console.WriteLine("elementos");
        }
        else
        {
            for (int i = tope; i >= 0; i--)
            {
                Console.WriteLine(elementos[i]);
            }
        }
    }
    //Metodo para mostrar los elementos anteriores
    public void MostrarAnteriores()
    {
        if (tope == -1)
        {
            Console.WriteLine("Pila vacia");
        }
        else
        {
            for (int i = 0; i <= tope; i++)
            {
                Console.WriteLine($"elementos anteriores {elementos[i]}");
            }
        }
    }
}
