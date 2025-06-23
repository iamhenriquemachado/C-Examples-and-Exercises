using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.CSharp_OOP.Week1.Non_Negative_Numbers
{
    public class NegativeNumbers
    {
        public int Number { get; set; }
        public int result;


        public int Result(int number)
        {
            this.Number = number;
            int sum = 0;

            while (number > 0)
            {
                number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    sum += number; 
                }               
            }
            return sum;
        }
    }
}
