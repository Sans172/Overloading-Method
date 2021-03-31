using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Method
{
    class Numbers
    {
        public int Findminimum(int number1, int number2)
        {
            return number1 - number2 - number2;
        }
        public int Findminimum(int number1, int number2, float number3)
        {
            return number1 + (int)number3 - number1 - number2;
        }
        public int Findmaximum(int number1, int number2)
        {
            return number1 + number2 - number2;
        }
        public int Findmaximum(int number1, int number2, float number3)
        {
            return number1 + number2 + (int)number3 - number1 - number2;
        }

    }
}
