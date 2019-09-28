using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta("ITLA");
            Console.WriteLine("El titular de la cuenta es: " + c.titular );
            Console.ReadKey();

            c.INGRESAR(-1500.00);
            c.INGRESAR(2500);
            c.INGRESAR(1000);
            Console.WriteLine("Sr. "+ c.titular + ", su balance es de: " + c.cantidad);
            Console.ReadKey();
            Console.WriteLine("Vamos a hacer un retiro!");
            Console.ReadKey();
            c.RETIRAR(0);
            Console.WriteLine("Sr. " + c.titular + ", su balance es de: " + c.cantidad);
            Console.ReadKey();
            c.RETIRAR(1500);
            Console.WriteLine("Sr. " + c.titular + ", su balance es de: " + c.cantidad);
            Console.ReadKey();
        }

        
    }
}
