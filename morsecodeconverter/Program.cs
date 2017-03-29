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
            using (var reader = new StreamReader(morseCodePath))
            {

            }

            Console.WriteLine("Enter a string of words and I will morsify it: ");
            

            Console.ReadLine();
        }
    }
}
