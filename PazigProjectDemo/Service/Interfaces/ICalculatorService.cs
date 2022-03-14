using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazigProjectDemo.Service.Interfaces
{
    public interface ICalculatorService
    {
        double Add(double number1, double number2);

        double Minus(double number1, double number2);
    }
}
