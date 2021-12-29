using System;
using System.Linq;

namespace Laba_4_Zadanie_2
{
    class Program
    {
        static char[] separators = { ' ', '-', ',', '.' };
        static string nomerMethod(string mainString, char[] separators)
        {
            string result = mainString;
            int n = 0, count = 1;
            string ourCount = null;
            int wordCounter = 0;
            for (int i = 1; i < mainString.Length; i++)
            {
                
                if (separators.Contains(mainString[i]) && !separators.Contains(mainString[i - 1]))
                {
                    wordCounter++;
                    ourCount = "(" + wordCounter + ")";
                    result = result.Insert(i + n, ourCount);
                    n += ourCount.Length;
                }
            }
            return result;
        }
        static string nomerArray(char[] ourArray)
        {
            string result = null;
            result = result + ourArray[0];
            int wordCounter = 0;
            for (int i = 1; i < ourArray.Length; i++)
            {
                if ((ourArray[i] == ' ' || ourArray[i] == '-' || ourArray[i] == '.' || ourArray[i] == ',') && (ourArray[i - 1] != ' ' && ourArray[i - 1] != '-' && ourArray[i - 1] != '.' && ourArray[i - 1] != ','))
                {
                    wordCounter++;
                    result = result + "(" + wordCounter + ")" + ourArray[i];
                }
                else
                {
                    result = result + ourArray[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, окончив его точкой (иначе твой комп взорвется):");
            string mainString = Console.ReadLine();
            Console.WriteLine("Наша строка, с которой мы работаем:\n{0}", mainString);

            char[] charArray = new char[mainString.Length];
            for (int i = 0; i < mainString.Length; i++)
            {
                charArray[i] = mainString[i];
                Console.Write(charArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("\nНу вот и результат (массив)!\n {0}", nomerArray(charArray));
            Console.WriteLine("\nНу вот и результат (методы)!\n {0}", nomerMethod(mainString, separators));

            
        }
    }
}
