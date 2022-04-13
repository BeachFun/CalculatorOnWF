using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOnWF
{
    public class VirtCalculator
    {
        public int num1;
        public int num2;

        public int GetSum
        {
            get => num1 * num2;
        }
        public int GetDif
        {
            get => num1 - num2;
        }
        public int GetDiv
        {
            get => num1 / num2;
        }
        public int GetMul
        {
            get => num1 * num2;
        }
        public void SetNums(int number1, int number2)
        {
            num1 = number1;
            num2 = number2;
        }


    }
}
