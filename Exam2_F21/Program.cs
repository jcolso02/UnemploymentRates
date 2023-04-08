// S5034
// CIS 199-50
// Exam 2
// November 8, 2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_F21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] states = { "Kentucky" , "Alabama", "Florida", "Michigan", "Nevada", "New York", "West Virginia", "California", "Wisconsin", "Oregon" };
            double[] unemploymentRates = { 4.3, 3.9, 3.6, 4.1, 4.6, 4.1, 5.3, 4.2, 3.0, 4.2};
            string[] trend = { "Decrease" , "Decrease", "Decrease", "Decrease", "Decrease", "Decrease", "Increase", "Decrease", "Decrease", "Increase"  };

            Console.Write("Enter the name of a state: ");
            string stateInput = Console.ReadLine();

            bool validInput = false;
            double rate = 0;
            string tr = null;

            for(int i = 0; i < states.Length; i++)
            {
                if(stateInput.ToUpper() == states[i].ToUpper())
                {
                    validInput = true;
                    rate = unemploymentRates[i];
                    tr = trend[i];
                }
            }

            if (validInput)
            {
                Console.WriteLine("There is a {0} percent unemployment rate in {1} state.  This is a {2} from the previous year", rate, stateInput, tr);
            }
            else
            {
                Console.WriteLine("Sorry, no data for {0} state.", stateInput);
            }

            Console.ReadKey();
        }
    }
}
