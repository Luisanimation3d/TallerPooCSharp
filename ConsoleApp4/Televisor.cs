using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Televisor : Electrodomestico
    {
        public double _resolucion = 0;
        public bool _sintonizadorTDT = false;

        public Televisor()
        {
        }

        public Televisor(double precio, double peso) : base(precio, peso) { }

        public Televisor(double resolucion, bool sintonizadorTDT, double precioBase, double peso, string color, char consumoEnergetico) : base(precioBase, peso, color, consumoEnergetico)
        {
            _resolucion = resolucion;
            _sintonizadorTDT = sintonizadorTDT;
        }

        public void precioFinal()
        {
            base.precioFinal();
            this._precioBase += this._resolucion > 40 ? 30 : 0;
            this._precioBase += this._sintonizadorTDT ? 50 : 0;
        }
    }
}
