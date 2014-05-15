using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunBuubles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("bubbling errors...");

            Console.WriteLine("a division by zero error");

            try {
                double result = Arup.Math.Divide.divide(123);
                Console.WriteLine(result.ToString());
            }
            catch(Exception ex) {
                Console.WriteLine("error occured" + ex.Message);
            }

            Console.ReadLine();

        }
    }
}
