using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase1
{
    public abstract class Figuras
    {
        public int Altura { get; set; }
        public int Ancho { get; set; }

        public abstract double CalcArea(int _altura, int _ancho, int radio = 0);
    }
}
