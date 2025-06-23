using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.CSharp_OOP.Week1.Even_Numbers
{
    public class EvenNumbers
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public List<int> ReturnNumbers(int firstNumber, int secondNumber)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;

            List<int> evenNumbers = new List<int>();
            int count = secondNumber + firstNumber + 1;
            int[] allNumbers = Enumerable.Range(firstNumber, count).ToArray();
            
            foreach(int number in allNumbers)
            {
                if(number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            return evenNumbers;
        }

    }
}
