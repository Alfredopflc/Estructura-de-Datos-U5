using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5._1_VenegasMedinaJoseAlfredo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6, m = 0; //inicializamos numero de elementos y variable auxiliar
            int[] nums = new int[6] { 2, 3, 1, 5, 6, 4 }; //inicializamos vector 

            for (int x = 1; x < n; x++) //Este for ira desde la segunda posicion hasta el final
            {
                for (int y = 0; y < (n - 1); y++) //Este ira desde la primera posicion hasta la final menos una
                {
                    if (nums[x] < nums[y]) //Esta condicion permite que sea ordenado de mayor a menos o de menor a mayor
                    {
                        m = nums[x]; //Variable de apoyo para conservar los valores antes de ser cambiados
                        nums[x] = nums[y]; //cambio de valores de x 
                        nums[y] = m; //cambio de valores de y
                    }
                }
            }

            for (int r = 0; r < n; r++) //for para imprimir el vector ya ordenado
                Console.Write(nums[r]);

            Console.ReadKey();
        }
    }
}
