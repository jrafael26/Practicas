using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase1
{
    public class ClaseArreglos
    {
       public static void Mayor ()
        {
            int[] arreglo = new int[10] { 1, 3, 2, 5, 4, 7, 8, 50, 20, 4 }; //En program al que pasarlo como parametro
            int max = arreglo[0];
            
            for (int i = 1; i < arreglo.Length; i++)
            {
                if (max< arreglo[i])
                {
                    max = arreglo[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
            
      public static void Suma()
        {
            int[] arreglo = new int[10] { 1, 3, 2, 5, 4, 7, 8, 50, 20, 4 };
            int suma = arreglo[0];

            for (int i = 1; i < arreglo.Length; i++)
            {
                suma = suma + arreglo[i];
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }

        //public int[] MayoresA18(int[] arreglo) // Tiene que devolver un arreglo con los valores mayores a 18
        //{
        //    arreglo = new int[5];
        //    for (int i = 0; i < arreglo.Length; i++)
        //    {
        //        if (arreglo[i]>18)
        //        {

        //        }
        //    }




        //    int[] result = new int[10];
        //}
    }
}
