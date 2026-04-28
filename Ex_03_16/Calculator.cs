using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_16
{
    public class Calculator
    {
        public int? Div(int x, int y)
        {
            int answer = 0;

            try
            {
                if(x <= 0)
                {
                    throw new InputParameterLessThanZeroException(x);
                }

                answer = x / y;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("例外:Attempted to divide by zero.");
                return null;
            }
            
            return answer;
        }
    }
}