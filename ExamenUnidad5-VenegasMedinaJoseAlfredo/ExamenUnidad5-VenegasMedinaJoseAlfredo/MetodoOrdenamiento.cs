using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad5_VenegasMedinaJoseAlfredo
{
    class MetodoOrdenamiento
    {
        public void Problema1() //Metodo Bubble Sort
        {
            int n = 0, m = 0; //inicializamos numero de elementos y variable auxiliar

            try  //Se utiliza un try catch para generar una excepcion si se esconge un elemento menor que 0 o mayor a 2
            {
                Console.Clear();
                Console.WriteLine("\t\n--Ejercicio 1 --");
                Console.Write("Ingrese cantidad de elementos de la lista: "); //Se pide el numero de elementos
                n = int.Parse(Console.ReadLine());

                int[] nums = new int[n]; //inicializamos vector con el tamano ingresado

                for (int i = 0; i < n; i++) //for para ingresar elementos
                {
                    Console.Write("Ingrese elemento del 0 al 2: "); 
                    nums[i] = int.Parse(Console.ReadLine());

                    if (nums[i] < 0 || nums[i] > 2) //Si es menos a 0 o mayor a 2 se crea una excepcion
                    {
                        i = n;
                        throw new OverflowException("No es un elemento valido");                     
                    }
                }

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

                Console.Write("\nLos Elementos Ordenados: ");
                for (int r = 0; r < n; r++) //for para imprimir el vector ya ordenado
                    Console.Write(nums[r] + " ");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Problema2() //Metodo Radix Sort
        {
            Console.Clear();
            Console.WriteLine("\t\n--Ejercicio 2 --");
            int[] VectRad = new int[80]; //Se inicializa nuestro arreglo con 80 elementos

            Random rnd = new Random(); //Metodo para elemento aleatorio

            for (int i = 0; i < 80;) //For para ingresar los datos aleatorios
            {
                int valor = rnd.Next(0, 100); //Valor tomara un elemento aleatorio del 0 al 100

                if (!VectRad.Contains(valor)) //Si valor no se encuentra en la lista, entonces se puede ingresar, esto para que no se repitan
                {
                    VectRad[i] = valor; 
                    i++;
                }
            }

            Console.WriteLine("Lista en Desorden: "); //Se imprime lista en Desorden
            foreach (int item in VectRad)
            {
                Console.Write(item + " ");
            }

            Radix(VectRad); //Llamamos al metodo Radix

            Console.WriteLine("\nLista en Orden: "); //Imprimimos en Orden
            foreach (int item in VectRad)
            {
                Console.Write(item + " ");
            }
        }

        public void Radix(int[] Arreglo)
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

        public void Problema3() //Metodo Shell Sort
        {
            Console.Clear();
            Console.WriteLine("\t\n--Ejercicio 3 --");
            int n = 0;
            Console.Write("Ingrese cantidad de elementos de la lista: "); //Se pide el numero de elementos
            n = int.Parse(Console.ReadLine());

            int[] nums = new int[n]; //inicializamos vector con el tamano ingresado

            for (int i = 0; i < n; i++) //for para ingresar elementos
            {
                Console.Write("Ingrese elemento {0}: ", i+1);
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nLista en Desorden: "); //Se imprime lista en Desorden
            foreach (int item in nums)
            {
                Console.Write(item + " ");
            }

            ShellSort(nums, nums.Length); //Mandamos a llamar al metodo Shell Sort

            Console.WriteLine("\nLista en Orden (De mayor a menor): "); //Imprimimos en Orden
            for(int i = nums.Length-1; i > 0; i--)
            {
                Console.Write(nums[i] + " ");
            }
            
        }

        public void ShellSort(int[] arreglo, int arr)

        {
            int buscar = arr / 2, i = 0, temp = 0, x = 0; 
            //Buscar sera el salto entre valores, que se optiene del tamano del arreglo entre 2 

            while (buscar > 0) //Se repetira hasta que buscar sea 0
            {
                i = 1;
                while (i != 0)
                {
                    i = 0;
                    x = 1;

                    while (x <= (arreglo.Length - buscar))
                    {
                        //Haremos una comparacion entre los valores que esten a la distancia de buscar, si es mayor se cambiaran
                        //de posicion gracias a la variable temp
                        if (arreglo[x - 1] > arreglo[(x - 1) + buscar])
                        {
                            temp = arreglo[(x - 1) + buscar];
                            arreglo[(x - 1) + buscar] = arreglo[x - 1];
                            arreglo[(x - 1)] = temp;
                            i = 1;
                        }

                        x++;
                    }
                }
                buscar = buscar / 2; //Se va a reducir hasta llegar a 0
            }
        
        }

        public void Problema4() //Metodo Quick Sort
        {
            Console.Clear();
            Console.WriteLine("\t\n--Ejercicio 4 --");
            string Letras = "lorem ipsum dolor sit amet, consectetur adipiscing elit. fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. duis ac massa est.";
            //Se modificaron las mayusculas por minusculas porque el programa las ponia antes que las minusculas
            char[] arreglo = new char[Letras.Length]; //Se inicia un arreglo con el tamano de la frase
            int i= 0;

            foreach (char item in Letras) //se agrega cada caracter de la frase y un contador para indicar la posicion del elemento
            {
                arreglo[i] = item; 
                i++;
            }

            Console.WriteLine("\nLista en Desorden: "); //Imprimimos en desorden
            foreach(char item in arreglo)
            {
                Console.Write(item + " ");
            }

            Quicksort(arreglo, 0, arreglo.Length - 1); //Llamamos al metodo Quick Sort

            Console.WriteLine();
            Console.WriteLine("\nLista en Orden: "); //Imprimimos en Orden
            foreach (char item in arreglo)
            {
                Console.Write(item + " ");
            }
        }

        public void Quicksort(char[] arreglo, int primero, int ultimo) 
        {

            int i = primero, j = ultimo; //El valor de i empezara en 0, y el ultimo sera la ultima posicion del arreglo
            int central = (i + j) / 2; //Se suman las posiciones, entre dos, para encontrar el elementos pivote
            double pivote = Convert.ToInt32(arreglo[central]); //pivote sera dicho elemento

            do
            {
                while (Convert.ToInt32(arreglo[i]) < pivote) i++; //Si el elemento de la posicion i es menor al pivote, se le sumara 1 a i
                while (Convert.ToInt32(arreglo[j]) > pivote) j--; //Si el elemento de la posicion i es mayor al pivote, se le restara 1 a j

                if (i <= j) //Si i es menor o igual que j se intercambian los valores
                {
                    char temp = arreglo[i];
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
    }
}
