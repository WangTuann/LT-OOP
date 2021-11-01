using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassifiedAd
{
    class TestACoassifiedAd
    {
        static void Main(string[] args)
        {
            const double rate = 0.09;
            double total;
            UserCar data = new UserCar();
            data.words = 500;
            total = data.words * rate;
            Console.WriteLine("The price of the {0} words is {1}", data.words, total);
            Console.ReadKey();
        }
    }
    class UserCar
    {
        public int words { get; set; }
        public double price { get; }
    }

}