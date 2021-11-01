using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celcius, Fahrenheit;
            Console.WriteLine("Nhap vao gia tri do F");
            Fahrenheit = Convert.ToDouble(Console.ReadLine());
            Celcius = (Fahrenheit - 32) * 5 / 9;
            Celcius = Math.Round(Celcius, 1);
            Console.WriteLine("{0} do F bang {1} do C", Fahrenheit, Celcius);
            Console.ReadKey();
        }
    }
}
