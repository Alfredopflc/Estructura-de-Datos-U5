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
            RadixSort RS = new RadixSort();

            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("\nOriginal array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

            RS.Sort(arr);
            Console.WriteLine("\nSorted array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");
        }
    }
}
