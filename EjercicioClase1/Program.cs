using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase1.NumPares();
            Clase1.NumPerfecto(6);
            //ClaseArreglos.Mayor();
            //ClaseArreglos.Suma();
            Clase2 clase2 = new Clase2();
            //clase2.NumPerfectos(28);
            Cliente cli = new Cliente("Jrafael");
            cli.Depositar(500);
            cli.RetornarMonto();
            cli.Depositar(1500);
            cli.RetornarMonto();
            cli.Extraer(500);
            cli.RetornarMonto();

            //Banco
            Banco banco = new Banco();

            banco.DepositosTotales();
           
        }

        public class Clase2
        {

            //3.	Averigua si un número es perfecto.
            public void NumPerfectos(int numero)
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
                else {
                    Console.WriteLine("El {0} no es númeor Perfecto!!!", numero);
                    Console.ReadKey();
                }
            }

            //4.	Basado en los conocimientos de programación orientada a objetos. Realizar... Clase Cliente


        }

        public class Cliente
        {
            public string Nombre { get; set; }
            public double Monto { get; set; }

            public Cliente(string _nombre)
            {
                Nombre = _nombre;
                Monto = 0;
            }

            public Cliente(string _nombre, double _monto)
            {
                Nombre = _nombre;
                Monto = _monto;

            }

            public void Depositar(double _monto)
            {
                if (_monto <= 0) { return; }

                Monto = Monto+_monto;
            }

            public void Extraer(double _monto)
            {
                if (_monto <= 0 || Monto - _monto < 0) { Monto = 0; }

                Monto = Monto - _monto;
            }

            public double RetornarMonto()
            {
                return Monto;
                //Console.WriteLine("Su Balance es: {0} ", Monto);
                //Console.Read();
            }
        }

        public class Banco
        {
            Cliente cli1 = new Cliente("Cliente 1",500);
            Cliente cli2 = new Cliente("Cliente 2", 1000);
            Cliente cli3 = new Cliente("Cliente 3", 2000);

            //public Banco(Cliente[] cliente)
            //{
            //    var cli = cliente[3] { "Cliente 1","Cliente 2","Cliente 3"};

            //}

            public void Operar()
            {
                
                Console.WriteLine("Operando...");
            }

            public void DepositosTotales()
            {
                double Total = cli1.Monto + cli2.Monto + cli3.Monto;
                Console.WriteLine("El Balance es: {0} ", Total);
                Console.Read();
            }
        }

        //public void NumPares ()
        //{
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }

        //    Console.ReadKey();
        //}
    }
}
