using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Electrodomestico
    {
        public double _precioBase = 100;
        public enum _colorValidate
        {
            blanco, 
            negro, 
            rojo, 
            azul,
            gris
        };
        public enum _consumoEnergeticoValidate
        {
            A,
            B,
            C,
            D,
            E,
            F
        }
        public double _peso = 5;
        public string _color = "blanco";
        public char _consumoEnergetico = 'F';

        public Electrodomestico()
        {
        }

        public Electrodomestico(double precioBase, double peso)
        {
            _precioBase = precioBase;
            _peso = peso;
        }

        public Electrodomestico(double precioBase, double peso, string color, char consumoEnergetico) : this(precioBase, peso)
        {
            comprobarConsumoEnergetico(consumoEnergetico);
            comprobarColor(color.ToLower());
        }

        private void comprobarConsumoEnergetico(char letra)
        {

            Console.WriteLine("Ingresa aqui consumo");
            if (Enum.IsDefined(typeof(_consumoEnergeticoValidate), (int)letra))
            {
                _consumoEnergetico = letra; 
            }
            else
            {
                _consumoEnergetico = 'F';
            }
        }

        private void comprobarColor(String color)
        {
            Console.WriteLine("Ingresa aqui color");

            if (Enum.IsDefined(typeof(_colorValidate), _color))
            {
                _color = color;
            }
            else
            {
                _color = "blanco";
            }
        }

        public void precioFinal()
        {
            switch (_consumoEnergetico)
            {
                case 'A':
                    {
                        _precioBase += 100;
                        break;
                    }
                case 'B':
                    {
                        _precioBase += 80;
                        break;
                    }
                case 'C':
                    {
                        _precioBase += 60;
                        break;
                    }
                case 'D':
                    {
                        _precioBase += 50;
                        break;
                    }
                case 'E':
                    {
                        _precioBase += 30;
                        break;
                    }
                case 'F':
                    {
                        _precioBase += 10;
                        break;
                    }
            }
            if(_peso > 0 && _peso <= 19)
            {
                _precioBase += 10;
            }else if(_peso >= 20 && _peso <= 49)
            {
                _precioBase += 50;
            }else if(_peso >= 50 && _peso <= 79)
            {
                _precioBase += 80;
            }else if(_peso >= 80)
            {
                _precioBase += 100;
            }
        }
    }
}
