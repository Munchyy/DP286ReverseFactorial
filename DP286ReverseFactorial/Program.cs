using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP286ReverseFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] splitInputs = Properties.Resources.inputText.Split('\n');

            int inputInt = 0;

            foreach(string s in splitInputs)
            {
                if (int.TryParse(s,out inputInt))
                {
                    ReverseFactorial rFact = new ReverseFactorial(inputInt);
                }
                else
                {
                    Console.WriteLine("That's not an integer son!");
                }
            }

            Console.ReadKey();
        }
    }
}
