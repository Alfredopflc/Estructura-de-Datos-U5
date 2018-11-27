using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_VenegasMedinaJoseAlfredo
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickSort QS = new QuickSort(); //Se crea Objeto de la clase Quick Sort
            int num = 0;
            Console.Write("Cuantos elementos desea ingresar? \nR = "); //Se le puede pedir al usuario el tamano del arreglo
            num = int.Parse(Console.ReadLine());


            double[] Valores = new double[num]; //Arreglo base

            double[] Arreglo1 = { 11, 2, 3, 14, 18, 4, 5, -3, -1, 6, 9 }; //Estos son los arreglos puestos en clase
            double[] Arreglo2 = { 1, 3, 5, 7, 8, 3, 9, 0.7071, 16.5664, 12, 0, 10 };
            double[] Arreglo3 = { 3, 7, 15, 1.3333, 155, 100, 15, 1.732, 5, -5, 3, 2 };
            double[] Arreglo4 = { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };
 
            for(int i = 0; i < num; i++) //Este for es para ingresar los valores que se dean agregar
            {
                Console.Write("Ingrese numero: ");
                Valores[i] = double.Parse(Console.ReadLine());
            }

            QS.Quicksort(Valores, 0, Valores.Length - 1); //Se hace llamar al Metodo Quick Sort a cada arreglo para ser ordenado
            QS.Quicksort(Arreglo1, 0, Arreglo1.Length - 1);
            QS.Quicksort(Arreglo2, 0, Arreglo2.Length - 1);
            QS.Quicksort(Arreglo3, 0, Arreglo3.Length - 1);
            QS.Quicksort(Arreglo4, 0, Arreglo4.Length - 1);

            Console.WriteLine();
            QS.Imprimir(Valores); //Se Imprime el arreglo ya ordenado
            QS.Imprimir(Arreglo1);
            QS.Imprimir(Arreglo2);
            QS.Imprimir(Arreglo3);
            QS.Imprimir(Arreglo4);

            Console.ReadKey();
            
        }
       
    }
}
