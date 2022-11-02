using System;
using System.Collections.Generic;
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
            int x = 10000 - 3;
            int win;
            int draw;
            int lose;
            lose = 1;
            draw = 1;
            win = 1;



            Console.WriteLine("Pa na to");
            Random rnd = new Random();
            for (int y = 1; y <= x; y++)
            {
                int rng = rnd.Next(1, 4);
                int rng2 = rnd.Next(1, 4);
                if (rng == rng2)
                {
                    draw++;
                }
                if (rng == 1)
                {
                    if (rng2 == 2)
                    {
                        win++;
                    }
                    if (rng2 == 3)
                    {
                        lose++;
                    }
                }
                if (rng == 2)
                {
                    if (rng2 == 3)
                    {
                        win++;
                    }
                    if (rng2 == 1)
                    {
                        lose++;
                    }
                }
                if (rng == 3)
                {
                    if (rng2 == 1)
                    {
                        win++;
                    }
                    if (rng2 == 2)
                    {
                        lose++;
                    }
                }




            }
            Console.WriteLine("tyle bylo wygranych");
            Console.WriteLine(win);
            Console.WriteLine("tyle bylo remisow");
            Console.WriteLine(draw);
            Console.WriteLine("tyle bylo przegranych");
            Console.WriteLine(lose);
            int c = win + draw + lose;
            Console.WriteLine("tyle bylo gier jbc");
            Console.WriteLine(c);
        }


    }
}





