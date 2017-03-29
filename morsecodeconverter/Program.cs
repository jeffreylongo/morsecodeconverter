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
            bool stillTranslating = true;
            while (stillTranslating)
            {

                Console.WriteLine("Enter a word and I will morsify it: ");

                var userInputPath = "userInput.csv";
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

                using (var writer = new StreamWriter(userInputPath))
                {
                    foreach (var ch in userInput)
                    {
                        writer.Write(ch);
                        writer.WriteLine(morseCodeDictionary[ch]);
                    }

                }



                foreach (var ch in userInput)
                {
                    Console.Write(morseCodeDictionary[ch]);
                }


                Console.ReadLine();
            }
        }
    }
}
