using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtensionMethod
{
    static class Util
    {
        public static int ConvertToBase(this int i, int baseToConvertTo)  //Extension method this has to be in a static class

        {
            if (baseToConvertTo < 2 || baseToConvertTo > 10)
                throw new ArgumentException("Value cannot be converted to base " + 
                baseToConvertTo.ToString());
            int result = 0;
            int iterations = 0;
            do
            {
                int nextDigit = i % baseToConvertTo;
                i /= baseToConvertTo;
                result += nextDigit * (int)Math.Pow(10, iterations);
                iterations++;
            }
            while (i != 0); //terminal condition
            return result;
        }
    }
}
