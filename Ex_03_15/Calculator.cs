using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_15
{
    public class Calculator
    {
        public int Div(int x, int y)
        {
            int answer = 0;
            try
            {
                answer = x / y;
                return answer;
            }
            catch(DivideByZeroException)
            {
                throw new DivideByZeroException();
            }
        }
    }
}