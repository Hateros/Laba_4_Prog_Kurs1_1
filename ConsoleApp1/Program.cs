using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static string Symbols_once_arr(string text)
        {
            string newtext = "";
            List<char> symbols_once_arr = new List<char>();
            for (int i = 0; i < text.Length & text[i] != '.'; i++)
            {
                int count = 0;
                for (int j = 0; j < text.Length & text[i] != '.'; j++)
                {
                    if (text[i] == text[j])
                        count++;
                }
                if (count == 1)
                {
                    if (text[i] != ' ')
                        symbols_once_arr.Add(text[i]);
                }
            }
            for (int i = 0; i < symbols_once_arr.Count; i++)
            {
                newtext = newtext + symbols_once_arr[i] + "\t";
            }
            return newtext;
        }
        static string Symbols_once_method(string text)
        {
            string newtext = "";
            List<char> symbols_once_method = new List<char>();
            for (int i = 0; i < text.Length & text[i] != '.'; i++)
            {
                if (text.Count(x => x.Equals(text[i])) == 1)
                {
                    if (text[i] != ' ')
                        symbols_once_method.Add(text[i]);
                }
            }
            for (int i = 0; i < symbols_once_method.Count; i++)
            {
                newtext = newtext + symbols_once_method[i] + "\t";
            }
            return newtext;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение и закончите его точкой:");
            string text = Console.ReadLine().Trim();
            Console.WriteLine("Результат работы через обработку строки как массива символов:");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Symbols_once_arr(text));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Результат, с помощью методов класса string:");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Symbols_once_method(text));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}