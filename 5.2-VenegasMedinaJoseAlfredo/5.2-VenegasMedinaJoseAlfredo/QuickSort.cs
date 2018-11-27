using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_VenegasMedinaJoseAlfredo
{
    class QuickSort
    {
        public void Quicksort(double[] arreglo, int primero, int ultimo) //Metodo QuickSort
        {

            int i = primero, j = ultimo; //El valor de i empezara en 0, y el ultimo sera la ultima posicion del arreglo
            int central = (i + j) / 2; //Se suman las posiciones, entre dos, para encontrar el elementos pivote
            double pivote = arreglo[central]; //pivote sera dicho elemento

            do
            {
                while (arreglo[i] < pivote) i++; //Si el elemento de la posicion i es menor al pivote, se le sumara 1 a i
                while (arreglo[j] > pivote) j--; //Si el elemento de la posicion i es mayor al pivote, se le restara 1 a j

                if (i <= j) //Si i es menor o igual que j se intercambian los valores
                {
                    double temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                    i++;
                    j--;
                }

            } while (i <= j); //Se ciclara hasta que i sea menor o igual a j

            if (primero < j) //Si primero es menor que j, se usara recursividad con los valores de primero y j
                Quicksort(arreglo, primero, j);

            if (i < ultimo) //Si i es menor que ultimo, se usara recursividad con los valores de ultimo e i
                Quicksort(arreglo, i, ultimo);
        }

        public void Imprimir(double[] Datos) //Metodo para imprimir
        {
            for (int cont = 0; cont < Datos.Length; cont++) //Imprime el arreglo de forma ordenada
            {
                Console.Write(Datos[cont].ToString() + "  ");
            }

            Console.WriteLine();
        }
    }
}
