using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevValArgLinCmd
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args[0] == "Falla")
            {
                Console.WriteLine("El argumento ingresado es: {0}", args[0].ToString());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El argumento ingresado es: {0}", args[0].ToString());

                Console.ReadKey();
            }
        }
    }
}
