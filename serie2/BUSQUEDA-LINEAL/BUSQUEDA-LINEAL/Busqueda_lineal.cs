using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSQUEDA_LINEAL
{
    class Busqueda_lineal
    {//metodo que recibe un arreglo y un valor para  buscar
        public static int LinearSearch(int[] arr, int valor)
        { //recorre el arreglo para saber si el numero a buscar se encuentra 
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valor)
                {
                    //retorna elemento
                    return i; 
                }
            }
            // Retorna -1 si no lo encuentra
            return -1; 
        }

    }
}
