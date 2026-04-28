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

            if(x <= 0)
            {
                throw InputParameterLessThanZeroException(x);
            }

            try
            {
                answer = x / y;
            }
            catch(DivideByZeroException)
            {
                
                return null;
            }
            catch (FormatException)
            {
                
            }
            
            return answer;
        }
    }
}