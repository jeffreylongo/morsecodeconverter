using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morsecodeconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var morseCodePath = "morse.csv";
            var userInput = Convert.ToChar(Console.ReadLine());
            Dictionary<char, string> morseCodeDictionary = new Dictionary<char, string>();

            using (var reader = new StreamReader(morseCodePath))
            {
                
                while (reader.Peek() >= 0)
                {
                   var text = reader.ReadLine().Split(',');
                    morseCodeDictionary.Add(char.Parse(text[0]), text[1]);
                }
            }

            Console.WriteLine("Enter a string of words and I will morsify it: ");
            

            Console.ReadLine();
        }
    }
}
