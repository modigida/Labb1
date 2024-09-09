using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    public class InitializeString
    {
        public InitializeString()
        {

        }
        public void InitializeProgram()
        {
            EnterStringToHandle();
        }
        private void EnterStringToHandle()
        {
            string givenString = string.Empty;

            while (true)
            {
                Console.Write("Enter a string: ");
                givenString = Console.ReadLine();
                if (string.IsNullOrEmpty(givenString))
                {
                    Console.WriteLine("You have to enter a string.");
                }
                else
                {
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int index = 0;
            string[] stringToOutput = new string[givenString.Length];
            double totalSum = 0.0;

            for (int i = 0; i < givenString.Length; i++)
            {
                if (HandleAndPrintString.FindStringToPrint(givenString, index) == true)
                {
                    totalSum += HandleAndPrintString.PrintString(givenString, index);
                    Console.WriteLine();
                    index++;
                }
                else
                {
                    index++;
                    continue;
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sum of substrings: " + totalSum);
        }
    }
}
