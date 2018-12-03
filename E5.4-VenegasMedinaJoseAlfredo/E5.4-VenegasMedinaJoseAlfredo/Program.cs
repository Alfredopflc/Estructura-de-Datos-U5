using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5._4_VenegasMedinaJoseAlfredo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShellSort SS = new ShellSort();
            int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int n;

            n = arr.Length;
            Console.WriteLine("Original Array Elements :");
            SS.show_array_elements(arr);
            SS.shellSort(arr, n);
            Console.WriteLine("\nSorted Array Elements :");
            SS.show_array_elements(arr);
            Console.ReadKey();
        }
    }
}
