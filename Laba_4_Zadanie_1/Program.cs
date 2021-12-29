using System;

namespace Laba_4_Zadanie_1
{
    class Program
    {
        static string methodAndSymbols(string mainString)
        {
            string result = null;
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString.IndexOf(mainString[i]) == mainString.LastIndexOf(mainString[i]))
                {
                    result = result + mainString[i] + " ";
                }
            }

            return result;
        }
        static string SymbolsAndArray(char[] ourArray)
        {
            int sameSymbols = 0;
            string result = null;
            for (int i = 0; i < ourArray.Length; i++)
            {
                for (int j = 0; j < ourArray.Length; j++)
                {
                    if (ourArray[i] == ourArray[j])
                    {
                        sameSymbols++;
                    }

                }
                if (sameSymbols == 1)
                {
                    if (ourArray[i] != ' ' && ourArray[i] != '.')
                    {
                        result = result + ourArray[i] + " ";
                    }
                }
                sameSymbols = 0;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, окончив его точкой (иначе твой комп взорвется):");
            string mainString = Console.ReadLine();
            Console.WriteLine("Наша строка, с которой мы работаем:\n{0}", mainString);
            Console.WriteLine("Длина нашей строки: {0}", mainString.Length);

            char[] charArray = new char[mainString.Length];
            for (int i = 0; i < mainString.Length; i++)
            {
                charArray[i] = mainString[i];
                Console.Write(charArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("\nСимволы из предложения, которые не повторяются (методы): {0}", methodAndSymbols(mainString));
            Console.WriteLine("А теперь массивом: {0}", SymbolsAndArray(charArray));
            //не учитываем регистр + не выводим пробелы и точки
            

        }
    }
}
