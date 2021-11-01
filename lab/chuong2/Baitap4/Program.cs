using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDecimalTest
      
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=(double)589/17;
           decimal b= (Decimal)589/17;
            Console.WriteLine("a={0} \n b={1} \n",a, b);
            Console.ReadKey();
        }
    }
}
