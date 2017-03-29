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
            Console.WriteLine("Enter a word and I will morsify it: ");

            var morseCodePath = "morse.csv";
            var userInput = Console.ReadLine().ToUpper();
            Dictionary<char, string> morseCodeDictionary = new Dictionary<char, string>();

            using (var reader = new StreamReader(morseCodePath))
            {
                
                while (reader.Peek() >= 0)
                {
                   var text = reader.ReadLine().Split(',');
                    morseCodeDictionary.Add(char.Parse(text[0]), text[1]);
                }

            }


            foreach (var ch in userInput)
            {
                Console.WriteLine(morseCodeDictionary[ch]);
            }
            

            Console.ReadLine();
        }
    }
}
