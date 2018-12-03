using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5._3_VenegasMedinaJoseAlfredo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            RadixSort RS = new RadixSort(); //Objeto de la Clase RadixSort

            int[] Lista1 = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 }; //Listas asignadas en clase
            int[] Lista2 = new int[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            int[] Lista3 = new int[] { 10, 40, 36, 5, 24, 2, 5, 8 };
            int[] Lista4 = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            int[] Lista5 = new int[] { 25, 108, 1024, 12, 351, 251, 39 };

            //Se imprimen las listas en desorden
            Console.WriteLine("\t\nListas en Desorden: ");
            RS.Imprimir(Lista1);
            RS.Imprimir(Lista2);
            RS.Imprimir(Lista3);
            RS.Imprimir(Lista4);
            RS.Imprimir(Lista5);

            //Acomodo de las listas por RadixSort
            RS.Sort(Lista1);
            RS.Sort(Lista2);
            RS.Sort(Lista3);
            RS.Sort(Lista4);
            RS.Sort(Lista5);

            //Se imprimen las listas en orden
            Console.WriteLine();
            Console.WriteLine("\t\nListas en Orden: ");
            RS.Imprimir(Lista1);
            RS.Imprimir(Lista2);
            RS.Imprimir(Lista3);
            RS.Imprimir(Lista4);
            RS.Imprimir(Lista5);

            Console.ReadKey();
        }
    }
}
