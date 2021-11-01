using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            Console.WriteLine("type your message");
            message = Console.ReadLine();
            if (message.Length <= 140)
            {
                Console.WriteLine("message accepted");
            }
            else
            {
                Console.WriteLine("message does not accepted");
            }
            Console.ReadKey();
        }
    }
}
