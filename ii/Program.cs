using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica02
{
    struct Auto
    {
        private static string Marca { get; set; }
        private static string Tipo { get; set; }
        private static string Color { get; set; }
        private static string Kilometros { get; set; }
        private static string Precio { get; set; }

        public void LeerDatos()
        {
            try
            {
                Write("Marca: ");
                Marca = ReadLine();

                Write("Tipo: ");
                Tipo = ReadLine();

                Write("Color: ");
                Color = ReadLine();

                Write("Kilómetros: ");
                Kilometros = ReadLine();

                Write("Precio: ");
                Precio = ReadLine();
            } catch (Exception ex)
            {
                WriteLine(ex.ToString());
            }
        }

        public void ImprimirDatos()
        {
            WriteLine("Imprimiendo datos...");
            WriteLine($"Marca: {Marca}");
            WriteLine($"Tipo: {Tipo}");
            WriteLine($"Color: {Color}");
            WriteLine($"Kilómetros: {Kilometros}");
            WriteLine($"Precio: {Precio}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Auto();
            var car2 = new Auto();

            car1.LeerDatos();
            car1.ImprimirDatos();

            car2.LeerDatos();
            car2.ImprimirDatos();
        }
    }

    class Ejercicio2
    {
        public void Start()
        {
            Write("Kelvin: ");
            WriteLine($"Fahrenheit: {(double.Parse(ReadLine()) - 273.15) * 9/5 +32}");
        }
    }

    class Ejercicio1
    {
        public void Start()
        {
            Triangulo tr = new Triangulo();
            WriteLine("Cateto a calcular: ");
            WriteLine("1. Opuesto");
            WriteLine("2. Adyacente");
            Write("#? ");
            var opt = ReadLine();

            Write("Hipotenusa: ");
            tr.Hipotenusa = double.Parse(ReadLine());

            switch (opt)
            {
                case "1":
                    Write("Cateto adyacente: ");
                    tr.CatetoAdyacente = double.Parse(ReadLine());
                    WriteLine($"Cateto opuesto: {tr.CalcularCatetoOpuesto()}");
                    break;
                case "2":
                    Write("Cateto opuesto: ");
                    tr.CatetoOpuesto = double.Parse(ReadLine());
                    WriteLine($"Cateto adyacente: {tr.CalcularCatetoAdyacente()}");
                    break;
            }
        }
    }

    class Triangulo
    {
        public double CatetoOpuesto { get; set; }
        public double CatetoAdyacente { get; set; }
        public double Hipotenusa { get; set; }

        public double CalcularCatetoOpuesto() => Math.Sqrt(Math.Pow(Hipotenusa, 2) - Math.Pow(CatetoAdyacente, 2));
        public double CalcularCatetoAdyacente() => Math.Sqrt(Math.Pow(Hipotenusa, 2) - Math.Pow(CatetoOpuesto, 2));

    }

}
