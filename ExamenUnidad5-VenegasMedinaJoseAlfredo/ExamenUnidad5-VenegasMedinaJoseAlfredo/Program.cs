using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad5_VenegasMedinaJoseAlfredo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            MetodoOrdenamiento MO = new MetodoOrdenamiento(); //Objeto de la clase MetodoOrdenamiento

            Console.Write("Ingresar que ejercicio quiere realizar: "); //Menu
            opc = int.Parse(Console.ReadLine());

            if(opc == 1)
                MO.Problema1();

            else if (opc == 2)
                MO.Problema2();

            else if (opc == 3)
                MO.Problema3();

            else if (opc == 4)
                MO.Problema4();

            else
                Console.WriteLine("ERROR");

            Console.ReadKey();
        }
    }
}
