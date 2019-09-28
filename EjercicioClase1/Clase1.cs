using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase1
{
    public class Clase1
    {
        public static void NumPares()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }

        public static void NumPerfecto(int numero)
        {
            int div = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0) { div +=i; }
            }

            if (numero == div)
            {
                Console.WriteLine("El {0} es un númeor Perfecto!!!", numero);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El {0} no es númeor Perfecto!!!", numero);
                Console.ReadKey();
            }
        }
    }
}
