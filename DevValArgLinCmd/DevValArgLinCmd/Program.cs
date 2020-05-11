using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevValArgLinCmd
{
    class Program
    {
        public static int Main(string[] args)
        {
            if (args[0] == "Falla")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
