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

            string text = File.ReadAllText("С:/");//указать путь к файлу

            char[] delimiters = new char[] { ' ', '\r', '\n' };


            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // проверка скорости выполнения коллекции LinkedList
            var watchTwo = Stopwatch.StartNew();

            LinkedList<string> wordArrayLincedList = new LinkedList<string>();            

            foreach (var w in words)
                wordArrayLincedList.AddLast(w);
            //Ввод времени необходимое для заполнение Колекции LinkedList<>
            Console.WriteLine($"Вставка в  словарь LinkedList<>: {watchTwo.Elapsed.TotalMilliseconds}  мс");

            // проверка скорости выполнения коллекции List
            var watchOne = Stopwatch.StartNew();

            List<string> wordArrayList = new List<string>();

            foreach (var w in words)
                wordArrayList.Add(w);
            //Ввод времени необходимое для заполнение Колекции List<>
            Console.WriteLine($"Вставка в  словарь List<>: {watchOne.Elapsed.TotalMilliseconds}  мс");


            Console.ReadKey();
        }
    }
}
