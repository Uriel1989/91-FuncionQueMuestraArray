using System;

//Crea una función que muestre un array.

namespace _91_FuncionQueMuestraArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Array contenido = new Array();

            contenido.mostrarArray(valores);
        }
    }
}
