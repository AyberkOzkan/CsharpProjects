using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibOrtalamaHesap
{
    public class AverageCalculator
    {
        public double CalculateAvarage(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return 0;                
            }
            double sum = numbers.Sum();
            return sum / numbers.Count;
        }
    }
}
