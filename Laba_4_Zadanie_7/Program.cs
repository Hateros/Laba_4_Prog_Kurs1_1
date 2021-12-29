using System;
using System.Text.RegularExpressions;

namespace Laba_4_Zadanie_7
{
    class Program
    {
        static void sumOfMusicTime(string[] musicArray)
        {
            
            int indexOfLongest = 0;
            int indexOfShortest = 0;
            int sumOfTime = 0;
            int[] musicTime = new int[musicArray.Length];
            Regex regexForTime = new Regex(@"[0-6]?\d:[0-5]\d");
            for (int i = 0; i < musicArray.Length; i++)
            {
                Match match = regexForTime.Match(musicArray[i]);
                string temporaryString = null;
                temporaryString = match.Value.Replace(":", " ");
                //Console.WriteLine(temporaryString.Split(" "));
                string[] temporaryArray = temporaryString.Split(" ");
                musicTime[i] = int.Parse(temporaryArray[0]) * 60 + int.Parse(temporaryArray[1]);
                sumOfTime += musicTime[i];
            }

            int longest = musicTime[0];
            int shortest = musicTime[0];
            //Самая длинная песенка и Самая короткая пи песенка
            for (int i = 0; i < musicArray.Length; i++)
            {
                if (longest < musicTime[i])
                {
                    longest = musicTime[i];
                    indexOfLongest = i;
                }
                if (shortest > musicTime[i])
                {
                    shortest = musicTime[i];
                    indexOfShortest = i;
                }
            }

            int indexOfMinDif1, indexOfMinDif2;
            indexOfMinDif1 = 0;
            indexOfMinDif2 = 0;
            int MinDiff = Math.Abs(musicTime[0] - musicTime[1]);
            for (int i = 0; i < musicArray.Length; i++)
            {
                for (int j = i + 1; j < musicArray.Length; j++)
                {
                    if (Math.Abs(musicTime[i] - musicTime[j]) < MinDiff)
                    {
                        MinDiff = Math.Abs(musicTime[i] - musicTime[j]);
                        indexOfMinDif1 = i;
                        indexOfMinDif2 = j;
                    }
                }
            }
            //а вообще зря я всё в одну функцию впихнул...
            Console.WriteLine("Общее время, затраченное на прослушивание 10 треков = {0} секунд", sumOfTime);
            Console.WriteLine("Самая короткая песня - \n{0} \nСамая длинная песня - \n{1}", musicArray[indexOfShortest], musicArray[indexOfLongest]);
            Console.WriteLine("Пара песен с минимальной разницей во времени звучания: \n{0} \n{1}", musicArray[indexOfMinDif1], musicArray[indexOfMinDif2]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Тут вам ничего не нужно вводить =(");
            string [] musicArray = { "1. Gentle Giant – Free Hand[6:15]", //понравилась
                                     "2. Supertramp – Child Of Vision[07:27]",
                                     "3. Camel – Lawrence[10:46]", //понравилась
                                     "4. Yes – Don’t Kill The Whale[3:55]",
                                     "5. 10CC – Notell Hotel[04:58]", // вроде понравилась, но такое
                                     "6. Nektar – King Of Twilight[4:16]", //понравилась
                                     "7. The Flower Kings – Monsters & Men[21:19]",
                                     "8. Focus – Le Clochard[1:59]", //зачем оно тут...
                                     "9. Pendragon – Fallen Dream And Angel[5:23]",
                                     "10. Kaipa – Remains Of The Day(08:02)"        }; //понравилась 
            sumOfMusicTime(musicArray);

            
        }
    }
}
