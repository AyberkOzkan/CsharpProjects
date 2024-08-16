using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringManipulator
{
    public class InputHandler
    {
        public List<string> GetStrings()
        {
            Console.WriteLine("Karakter değiştirmek istediğiniz ifadeleri giriniz.");
            Console.WriteLine("Her bir ifadeyi Enter ile ayırınız, bitirmek için boş girdi girmeniz gerekmektedir.");
            List<string> strings = new List<string>();

            while (true) 
            { 
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                strings.Add(input);               
            }
            return strings;
        }
    }
}
