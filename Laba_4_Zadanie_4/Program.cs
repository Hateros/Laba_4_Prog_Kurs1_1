using System;

namespace Laba_4_Zadanie_4
{
    class Program
    {
        static string arrayCom(string[] ourArray)
        {

            for (int i = 0; i < ourArray.Length; i++)
            {
                char[] arrayOfStrings = ourArray[i].ToCharArray();
                for (int j = 0; j < arrayOfStrings.Length; j++)
                {
                    if (arrayOfStrings[j] == '.')
                    {
                        if (j + 4 <= arrayOfStrings.Length - 1)
                        {
                            if (arrayOfStrings[j + 1] == 'c' && arrayOfStrings[j + 2] == 'o' && arrayOfStrings[j + 3] == 'm')
                            {
                                Console.WriteLine(ourArray[i]);
                            }
                        }
                    }
                }
            }
            return "Ну типа вот.";
        }
        static string methodCom(string[] ourArray)
        {
            for (int i = 0; i < ourArray.Length; i++)
            {
                if (ourArray[i].Contains(".com") || ourArray[i].Contains(".com,") || ourArray[i].Contains(".com."))
                {
                    Console.WriteLine(ourArray[i]);
                }
            }
            return "Ну типа вот.";
        }
            static void Main(string[] args)
        {
            string[] mainArray = new string[6];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите строки:");
                mainArray [i] = Console.ReadLine();
            }
            Console.WriteLine("Методами:");
            Console.WriteLine(methodCom(mainArray));
            Console.WriteLine("Массивом:");
            Console.WriteLine(arrayCom(mainArray));
            int spaceCounter = 0;
            int tempSpaceCounter;
            int whereFewOfSpaces = 1;
            for (int i = 0; i < mainArray.Length; i++)
            {
                char[] arrayOfStrings = mainArray[i].ToCharArray();
                for (int j = 0; j < arrayOfStrings.Length; j++)
                {
                    if (arrayOfStrings[j] == ' ')
                    {
                        spaceCounter++;
                    }
                }
                tempSpaceCounter = spaceCounter;
                if (spaceCounter <= tempSpaceCounter)
                {
                    whereFewOfSpaces = i + 1;
                }
                spaceCounter = 0;
            }
            Console.WriteLine("Меньше всего пробелов в строке: {0}", whereFewOfSpaces);
            
        }
    }
}
