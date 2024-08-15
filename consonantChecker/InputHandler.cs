using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consonantChecker
{
    public class InputHandler
    {
        public List<string> GetStrings() 
        {
            Console.WriteLine("(her bir ifadeyi Enter ile ayırınız, bitirmek için boş girin)");
            Console.Write("Kontrol etmek istediğiniz string ifadeleri giriniz:");
            List<string> strings = new List<string>();

            while (true)
            {
                string? input = Console.ReadLine();
                if(string.IsNullOrEmpty(input))
                {
                    break;
                }
                strings.Add(input);
            }
            return strings;
        }
    }
}
