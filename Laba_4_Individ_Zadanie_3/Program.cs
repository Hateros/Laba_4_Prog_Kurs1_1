using System;
using System.Text.RegularExpressions;

namespace Laba_4_Individ_Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку типа: 23:15:59");
            string mainString = Console.ReadLine();
            Regex regexForMainString = new Regex(@"[0-2]\d:[0-6]\d:[0-6]\d");
            Regex regexForMainString2 = new Regex(@"[0-6]\d");
            MatchCollection matches = regexForMainString.Matches(mainString);
            Match matches2 = regexForMainString2.Match(mainString);
            if (matches.Count > 0)
            {
                mainString = Regex.Replace(mainString, ":", " ");
                string[] temporaryArray = mainString.Split(" ");
                Console.WriteLine(mainString);
                string a = matches2.Value;
                matches2 = matches2.NextMatch();
                string b = matches2.Value;
                matches2 = matches2.NextMatch();
                string c = matches2.Value;
                Console.WriteLine("Часы = {0}, минуты = {1}, секунды = {2}!", a, b, c);
            }
            
        }
    }
}
