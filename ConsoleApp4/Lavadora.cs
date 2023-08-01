using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Lavadora: Electrodomestico
    {
        public double _carga = 5;

        public Lavadora() { }
        public Lavadora(double precio, double peso) : base(precio, peso){ }
        public Lavadora(double carga, double precioBase, double peso, string color, char consumoEnergetico)
            :base(precioBase, peso, color, consumoEnergetico)
        {
            _carga = carga;
        }

        public void precioFinal()
        {
            base.precioFinal();
            if(_carga > 30)
            {
                this._precioBase += 50;
            }
        }
    }
}
