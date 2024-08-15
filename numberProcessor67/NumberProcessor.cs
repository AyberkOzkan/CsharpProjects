using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberProcessor67
{
    public class NumberProcessor
    {
        public (int sumOfDifferences, int sumOfSquaredDifferences) ProcessNumbers(List<int> numbers) 
        { 
            int sumOfDifferences = 0;
            int sumOfSquaredDifferences = 0;
            foreach (int number in numbers)
            {
                int difference = number - 67;

                if (difference < 0)
                {
                    sumOfDifferences += Math.Abs(difference);
                } else
                {
                    sumOfSquaredDifferences += (int)Math.Pow(difference, 2);
                }
            }
            return (sumOfDifferences, sumOfSquaredDifferences);
        }
    }
}
