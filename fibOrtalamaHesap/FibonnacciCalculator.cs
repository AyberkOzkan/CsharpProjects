using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibOrtalamaHesap
{
    public class FibonacciCalculator
    {
        public List<int> GenerateSeries(int depth)
        {
            List<int> series = new List<int> { 0, 1 };
            for (int i = 2; i < depth; i++)
            {
                int nextValue = series[i -1] + series[i -2];
                series.Add(nextValue);
            }

            return series;
        }
    }
}
