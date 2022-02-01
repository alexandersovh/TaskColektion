using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace TaskColektion
{
    class Program
    {
        static void Main(string[] args)
        {
            //запуск таймера


            string text = File.ReadAllText("C:/Users/alexandr/OneDrive/Рабочий стол/trening/Text1.txt");

            char[] delimiters = new char[] { ' ', '\r', '\n' };


            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);




            var watchTwo = Stopwatch.StartNew();

            LinkedList<string> wordArrayLincedList = new LinkedList<string>();            

            foreach (var w in words)
                wordArrayLincedList.AddLast(w);

            Console.WriteLine($"Вставка в  словарь LinkedList<>: {watchTwo.Elapsed.TotalMilliseconds}  мс");





            var watchOne = Stopwatch.StartNew();

            List<string> wordArrayList = new List<string>();

            foreach (var w in words)
                wordArrayList.Add(w);

            Console.WriteLine($"Вставка в  словарь List<>: {watchOne.Elapsed.TotalMilliseconds}  мс");

            Console.ReadKey();
        }
    }
}
