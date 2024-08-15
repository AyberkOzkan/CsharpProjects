using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairProcessor
{
    public class PairProcessor
    {
        public int ProcessorPair(int num1 , int num2)
        {
            int sum = num1 + num2;
            return num1 == num2 ? sum * sum : sum;
        }
    }
}
