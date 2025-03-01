using BUSQUEDA_LINEAL;
using System;

public abstract class Program
{ 
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenidos al programa de Busqueda Lineal ");
        Console.WriteLine("Ingrese los elementos del arreglo separados por espacios: ");

        string? input = Console.ReadLine();

        // Si la entrada es null, asignamos una cadena vacía para evitar errores
        int[] arr = (input ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
        //validacion de arrgeglo vacio 
        if (arr.Length == 0)
        {
            Console.WriteLine("No se ingresaron elementos en el arreglo");
            return;
        }
        //solicita al usuario que ingrese el numero a buscar 
        Console.Write("Ingrese el valor a buscar: ");
        int valor = int.Parse(Console.ReadLine());

        int result = Busqueda_lineal.LinearSearch(arr, valor);
        //validacion de resultado final 
        if (result != -1)
        {
            Console.WriteLine($"El número {valor} se encuentra en la posición {result}.");
        }
        else
        {
            Console.WriteLine($"El número {valor} no está en el arreglo.");
        }
    }

}
    
