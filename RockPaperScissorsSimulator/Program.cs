using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RockPaperNozyc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type how many games you want to be simulated: ");
            string line = Console.ReadLine();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            double x = double.Parse(line);
            int win = 0;
            int draw = 0;
            int lose = 0;

            Random rnd = new Random();
            for (int y = 0; y < x; y++)
            {
                switch(rnd.Next(0,3))
                {
                    case 0: win++; break;
                    case 1: draw++; break;
                    case 2: lose++; break;
                }
            }
            Console.WriteLine("tyle bylo wygranych\n" + win);
            Console.WriteLine("tyle bylo remisow\n" + draw);
            Console.WriteLine("tyle bylo przegranych\n" + lose);
            int c = win + draw + lose;
            Console.WriteLine("tyle bylo gier jbc\n" + c);
            stopwatch.Stop();

            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }


    
}





