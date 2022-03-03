using PazigProjectDemo.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazigProjectDemo.Service
{
    public sealed class CalculatorService : ICalculatorService
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Minus(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
