﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis
{
    class Program
    {
        static void Main(string[] args)
        {
            KataTennisGame game = new KataTennisGame("Nadal", "Federer");

            while (!game.AWinner())
            {
                game.randomScore();
                Console.WriteLine(game.getGlobalScore());

            }


            Console.ReadLine();
        }

    }
}
