using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                Console.WriteLine($"La suma de 15 numeros es:(SumaNumeros(list))");
                Console.WriteLine($"La suma pares de 15 numeros es:(SumaPares(list))");
                Console.WriteLine($"La suma impares de 15 numeros es:(Sumalmpares(list)");
                Console.WriteLine($" La suma d de 1e 10 numeros ramdos es:(SumaRandoms()");


                int suma = SumaNumeros(list);
                Console.WriteLine(suma);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex.ToString()}");

            }

        }

        static int SumaNumeros(List<int> lista)
        {
            int suma = 0;
            foreach (int i in lista)
            {
                //Comentarios como va haciendo la suma
                //55
                /*
                 0,1,2,3,4,5,6,7,8,9,10
                */
                suma += i;

            }
            return suma;
        }
        
        static int SumaPares(List<int> lista)
        {
            int sumapares = 0;
            foreach (var n in lista)
                if (n % 2 == 0)
                    sumapares += n;//Como va incrementnado la suma de los pares.
            return sumapares;
        }
        /*
         0,1,3,6,10,15,21,28,36,45,55,66,78,91,105,
         */
        
        static int SumaRandoms()
        {
            Random random = new Random();
            int suma = 0;
            for (int i = 0; i < 10; i++)
                suma += random.Next(1, 11); //Como va incrementando la suma
            return suma;
        }
        /*
         0,1,3,6,10,15,21,28,36,45
         */
        static int SumaImPares(List<int> lista)
        {
            int sumaimpares = 0;
            foreach (var n in lista)
                if (n % 2 == 0)
                    sumaimpares += n;//Como va incrementnado la suma de los pares.
            return sumaimpares;
        }
        /*
         0,1,3,6,10,15,21,28,36,45,55,66,78,91,105,
         */
    }
}
