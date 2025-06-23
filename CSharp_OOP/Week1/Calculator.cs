using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.CSharp_OOP.Week1.Calculator
{
    public class Calculator
    {
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public string Operation { get; set; }
        public int result; 

        public double CalculateResult(string operation, int firstValue, int secondValue)
        {
            Operation = operation; 
            FirstValue = firstValue;
            SecondValue = secondValue;
            
            switch(operation)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "/":
                    result = firstValue / secondValue;
                    break;
                case "*":
                    result = firstValue * secondValue;
                    break;
            }
            return result; 
            

        }
    }
}
