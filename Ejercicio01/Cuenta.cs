using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01

{
    public class Cuenta
    {
        
        public Cuenta(string _titular)
        {
            titular = _titular;
            cantidad = 0;
        }

        public Cuenta(string _titular, int _cantidad)
        {
            titular = _titular;
            cantidad = _cantidad;
        }

        public string titular { get; set; }
        public double cantidad { get; set; }


        public void INGRESAR(double _cantidad)
        {
            if (_cantidad<0) { return; }
            cantidad = cantidad+_cantidad;
        }

        public void RETIRAR (double _cantidad)
        {
            if ((cantidad-_cantidad)<0) { cantidad = 0; }
            cantidad = cantidad - _cantidad;
        }

        

    }

}
