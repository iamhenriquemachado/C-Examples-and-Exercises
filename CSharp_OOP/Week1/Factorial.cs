using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Factorial
    {
        public int FactorialNumber { get; set; }


        public int FactorialCalculus(int f)
        {
            if(f == 0)
            {
                return 1;
            } return f * FactorialCalculus(f - 1);

        }
    }
}
