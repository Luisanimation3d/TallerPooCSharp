using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double precio = 0;
            double peso = 0;
            string color = "";
            char consumoEnergetico = '.';
            double carga = 0;
            double resolucion = 0;
            bool sintonizadorTDT = false;
            double precioElectrodomestico = 0;
            double precioLavadora = 0;
            double precioTelevision = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Selecciona una de la siguientes opciones:\n1. Electrodoméstico\n2. Lavadora\n3. Televisión");

                opcion = int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Digite el precio del electrodoméstico");
                            precio = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el peso del electrodoméstico");
                            peso = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el color del electrodoméstico");
                            color = Console.ReadLine();
                            Console.WriteLine("Digite el consumo energético del electrodoméstico");
                            consumoEnergetico = char.Parse(Console.ReadLine().ToUpper());
                            Electrodomestico electrodomestico = new Electrodomestico(precio, peso, color, consumoEnergetico);
                            electrodomestico.precioFinal();
                            Console.WriteLine($"el precio final del electrodoméstico es: {electrodomestico._precioBase}");
                            precioElectrodomestico += electrodomestico._precioBase;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Digite el precio del electrodoméstico");
                            precio = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el peso del electrodoméstico");
                            peso = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el color del electrodoméstico");
                            color = Console.ReadLine();
                            Console.WriteLine("Digite el consumo energético del electrodoméstico");
                            consumoEnergetico = char.Parse(Console.ReadLine().ToUpper());
                            Console.WriteLine("Digite la carga de la lavadora");
                            carga = double.Parse(Console.ReadLine());
                            Lavadora lavadora = new Lavadora(carga, precio, peso, color, consumoEnergetico);
                            lavadora.precioFinal();
                            Console.WriteLine($"El precio final de la lavadora es: {lavadora._precioBase}");
                            precioElectrodomestico += lavadora._precioBase;
                            precioLavadora += lavadora._precioBase;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Digite el precio del electrodoméstico");
                            precio = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el peso del electrodoméstico");
                            peso = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el color del electrodoméstico");
                            color = Console.ReadLine();
                            Console.WriteLine("Digite el consumo energético del electrodoméstico");
                            consumoEnergetico = char.Parse(Console.ReadLine().ToUpper());
                            Console.WriteLine("Digite la resolucion de la televisión");
                            resolucion = double.Parse(Console.ReadLine());
                            Console.WriteLine("¿La televisión tiene sintonizador TDT? S/N");
                            sintonizadorTDT = Console.ReadLine() == "S";
                            Televisor televisor  = new Televisor(resolucion, sintonizadorTDT, precio, peso, color, consumoEnergetico);
                            televisor.precioFinal();
                            Console.WriteLine($"El precio final de la televisión es: {televisor._precioBase}");
                            precioElectrodomestico += televisor._precioBase;
                            precioTelevision += televisor._precioBase;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Seleccionaste una opción incorrecta");
                            break;
                        }
                }

            }

            Console.WriteLine($"Lo precios acumulados son:\nElectrodoméstico: {precioElectrodomestico}\nLavadora: {precioLavadora}\nTelevision: {precioTelevision}");

        }
    }
}
