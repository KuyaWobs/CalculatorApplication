using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{

    public delegate T Formula <T>(T txtBoxInput1, T txtBoxInput2);

    internal class CalculatorClass
    {
        public Formula <double> info;

        public double GetSum(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1  + txtBoxInput2;
        }

        public double GetDifference(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 - txtBoxInput2;
        }

        public double GetProduct(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 * txtBoxInput2;
        }

        public double GetQuotient(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 / txtBoxInput2;
        }

        public event Formula <double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
            }
        }
    }
}