using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class Persona
    {
        public Persona()
        {

        }

        public string nombre { get; set; }
        public int edad { get; set; }

        public void LoadPersona(string _nombre, int _edad)
        {
            nombre =_nombre;
            edad = _edad;
        }

        public void ImprimirPersona()
        {
            Console.WriteLine("Su nombre es: " + nombre + "y tiene: " + edad+ "años de edad." );
            
        }
    }
}
