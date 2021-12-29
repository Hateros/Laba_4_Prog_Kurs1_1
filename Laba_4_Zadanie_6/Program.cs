using System;
using System.Text.RegularExpressions;

namespace Laba_4_Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи пример а + в = с (да, ставь сколько угодно пробелов):");
            string mainString = Console.ReadLine();
            mainString = Regex.Replace(mainString, " ", "");
            Console.WriteLine(mainString);
            //Вся строка Regex regexForMainString = new Regex(@"-?\d+\+-?\d+=\d+");
            Regex regexForMainString = new Regex(@"-?\d+");
            Match matches = regexForMainString.Match(mainString);
            int a = int.Parse(matches.Value);
            matches = matches.NextMatch();
            int b = int.Parse(matches.Value);
            matches = matches.NextMatch();
            int c = int.Parse(matches.Value);
            Console.WriteLine("Крутая переменная a = {0}, b = {1}, c = {2}!", a, b, c);
        }
    }
}
