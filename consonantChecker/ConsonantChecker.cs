using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consonantChecker
{
    public class ConsonantChecker
    {
        private readonly char[] consonants = new char[]
        {
            'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm',
            'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'
        };
        public bool HasConsecutiveConsonants(string input)
        {
            input = input.ToLower();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (IsConsonant(input[i]) && IsConsonant(input[i + 1]))
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsConsonant(char ch) => Array.IndexOf(consonants, ch) >= 0;
    }
}
