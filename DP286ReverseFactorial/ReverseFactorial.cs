using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP286ReverseFactorial
{
    class ReverseFactorial
    {
        private int factorialInt;

        public ReverseFactorial(int inputInt)
        {
            factorialInt = inputInt;
            if (factorialInt < 0)
            {
                Console.WriteLine("This number is not positive");
            }else
            {
                string output = FindReverseFactorial(factorialInt, 1).ToString();
                if (output.Equals("-1"))
                    output = "None";
                Console.WriteLine("Base factorial of {0} is {1}!", factorialInt, output);
            }
        }


        //recursive method to find the factorial for this number
        private int FindReverseFactorial(int input, int divisor)
        {
            if (input == 1)
                return 1;
            else if (input % divisor == 0)
            {

                input = input / divisor;

                if (input == 1)
                    return divisor;
                else
                    return FindReverseFactorial(input, ++divisor);
            }
            else
                return -1;
        }
    }
}
