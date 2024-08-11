using System;

namespace stringSwapper
{
    public class StringSwapper
    {
        public string SwapAdjacentCharacters(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
                return input;

            // İlk karakteri alıp string'in sonuna taşıyoruz
            string modifiedInput = input.Substring(1) + input[0];

            char[] chars = modifiedInput.ToCharArray();

            return new string(chars);
        }
    }
}
