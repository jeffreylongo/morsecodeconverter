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
                var userMorse = "";
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
                    var temp = morseCodeDictionary[ch];
                    userMorse += temp;
                    Console.WriteLine(temp);
                }

                using (StreamWriter w = File.AppendText(userInputPath))
                {
                    w.WriteLine($"{userInput},{userMorse}");
                }

                Console.WriteLine("Still translating? [Y] [N]");
                var input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    stillTranslating = true;
                }
                else if (input.ToLower() == "n")
                {
                    stillTranslating = false;
                }
                else
                {
                    Console.WriteLine("Type [Y] or [N]...follow directions");
                }

            }
        }
    }
}
