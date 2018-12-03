using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5._3_VenegasMedinaJoseAlfredo
{
    class RadixSort
    {
        public void Sort(int[] Arreglo) //Metodo para acomodar las listas
        {
            int i, j;
            int[] tmp = new int[Arreglo.Length]; //Metodo Temporal

            for (int cont = 31; cont >= 0; --cont) //Iniciamos for desde 31
            {
                j = 0;
                for (i = 0; i < Arreglo.Length; ++i) //Se evaluaran con respecto al tamano del arreglo
                {
                    bool move = (Arreglo[i] << cont) >= 0; //Si es mayor o igual a 0, sera verdadero
                    if (cont == 0 ? !move : move) //Evaluamos move y se compara con lo contrario
                        Arreglo[i - j] = Arreglo[i]; //Intercambiamos valores

                    else 
                        tmp[j++] = Arreglo[i]; //Si no, lo movemos al arreglo auxiliar
                }
                Array.Copy(tmp, 0, Arreglo, Arreglo.Length - j, j);
                //Array.Copy sirve para mover los valores de un arreglo a otro desde la cantidad que le sea asignada
                //de modo: arreglo fuente, valor de inicio, arreglo destino, valor de destino, tamano de arreglo
            }
        }

        public void Imprimir(int[] arr) //Metodo para imprimir las listas
        {          
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }     
    }
}
