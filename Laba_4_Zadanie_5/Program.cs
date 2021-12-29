using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Laba_4_Zadanie_5
{
    class Program
    {
        static string regexNames(string ourString)
        {
            Regex regex = new Regex(@"[A-Z]\w*\d\d+");
            MatchCollection matches = regex.Matches(ourString);
            foreach (Match match in matches)
            {
                Console.Write("{0} ", match.Value);
            }
            return "\nВроде работает...";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, умоляю, строку:");
            string mainString = Console.ReadLine();
            Console.WriteLine("Регулярными выражениями:");
            Console.WriteLine(regexNames(mainString));
            Console.WriteLine("Массивом:");
            Console.WriteLine(arrayNames(mainString));

            
            //массивом пока не работает
            static string arrayNames(string ourString)
            {
                string result = null;
                char[] ourCharString = ourString.ToCharArray();
                for (int i = 0; i < ourCharString.Length; i++)
                {
                    if ((ourCharString[i] >= '0' && ourCharString[i] <= '9') && (i + 1 < ourCharString.Length))
                    {
                        if (i + 2 != ourCharString.Length)
                        {
                            if ((ourCharString[i + 1] >= '0' && ourCharString[i + 1] <= '9'))
                            {
                                if (ourCharString[i + 2] == ' ' && ourCharString[i + 2] == ',' && ourCharString[i + 2] == '.')
                                {
                                    int iTemp = i + 1;
                                    for (int j = i + 1; j != 0; j--)
                                    {
                                        if ((ourCharString[j] == ' ' || j == 0) && (ourCharString[j + 1] >= 'A' && ourCharString[j + 1] <= 'Z'))
                                        {
                                            for (int k = j + 1; k <= iTemp; k++)
                                            {
                                                result += ourCharString[k];
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else 
                        {
                            if ((ourCharString[i + 1] >= '0' && ourCharString[i + 1] <= '9'))
                            {
                                int iTemp = i + 1;
                                for (int j = i + 1; j != 0; j--)
                                {
                                    if ((ourCharString[j] == ' ' || j == 0) && (ourCharString[j + 1] >= 'A' && ourCharString[j + 1] <= 'Z'))
                                    {
                                        for (int k = j + 1; k <= iTemp; k++)
                                        {
                                            result += ourCharString[k];
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
                return result;
            }
        }
    }
}
