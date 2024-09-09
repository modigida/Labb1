using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    public class HandleAndPrintString
    {
        public HandleAndPrintString()
        {

        }

        public static bool FindStringToPrint(string funcGivenString, int funcIndex)
        {
            bool isPrintable = false;
            int endNumber = funcGivenString.Length;

            for (int i = funcIndex; i < funcGivenString.Length; i++)
            {
                char targetChar = funcGivenString[funcIndex];

                if (!Char.IsDigit(funcGivenString[i]))
                {
                    isPrintable = false;
                    break;
                }
                else if (funcGivenString[i] == targetChar && i > funcIndex)
                {
                    isPrintable = true;
                    break;
                }
                else if (funcGivenString[i] != targetChar && funcGivenString[i] == endNumber)
                {
                    isPrintable = false;
                }
            }
            return isPrintable;
        }
        public static double PrintString(string funcStringToPrint, int funcIndex)
        {
            string substringNumber = string.Empty;
            bool isRedMode = true;

            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < funcIndex; i++)
            {
                Console.Write(funcStringToPrint[i]);
            }

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = funcIndex; i < funcStringToPrint.Length; i++)
            {
                char targetChar = funcStringToPrint[funcIndex];

                if (!Char.IsDigit(funcStringToPrint[i]))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(funcStringToPrint[i]);
                    isRedMode = false;
                }
                else if (isRedMode == false)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(funcStringToPrint[i]);
                }
                else if (funcStringToPrint[i] == targetChar && i > funcIndex)
                {
                    Console.Write(funcStringToPrint[i]);
                    substringNumber += funcStringToPrint[i];
                    Console.ForegroundColor = ConsoleColor.White;
                    isRedMode = false;
                }
                else
                {
                    Console.Write(funcStringToPrint[i]);
                    substringNumber += funcStringToPrint[i];
                }
            }
            double sumOfSubstrings = double.Parse(substringNumber);

            return sumOfSubstrings;
        }
    }
}
