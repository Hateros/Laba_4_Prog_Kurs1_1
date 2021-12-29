using System;

namespace Laba_4_Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, окончив его точкой (иначе твой комп взорвется):");
            string mainStroka = Console.ReadLine();
            Console.WriteLine("Наша строка, с которой мы работаем:\n{0}", mainStroka);
            Console.WriteLine("Длина нашей строки: {0}", mainStroka.Length);

            char[] charArray = new char[mainStroka.Length];
            for (int i = 0; i < mainStroka.Length; i++)
            {
                charArray[i] = mainStroka[i];
                Console.Write(charArray[i]);
            }
            Console.WriteLine("\nНу вот и результат!\n {0}", obratnoArray(charArray));

            static string obratnoArray(char[] OurArray)
            {
                string Result = null;
                //Result = Result + OurArray[0];
                for (int i = OurArray.Length - 1; i > 1; i--)
                //for (int i = 0; i < OurArray.Length; i++)
                {
                    while (OurArray[i - 1] != ' ' && OurArray[i - 1] != '-' && OurArray[i - 1] != '.' && OurArray[i - 1] != ',')
                    {

                        Result = OurArray[i - 1] + Result;
                        i++;
                    }

                    //Result = OurArray[i] + Result;
                }
                return Result;
            }
        }
    }
}
