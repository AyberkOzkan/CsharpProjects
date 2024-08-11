using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeCharAtIndex
{
    public class StringProcessor
    {
        public string RemoveCharacterAtIndex(string input, int index)
        {
            if (index < 0 || index >= input.Length)
            {
                return input;
            }

            return input.Remove(index, 1);
        }
    }
}
