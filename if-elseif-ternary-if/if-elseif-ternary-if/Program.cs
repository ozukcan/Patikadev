﻿using System;

namespace if_elseif_ternary_if
{
    class Program
    {
        static void Main(string[] args)
        {

            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("iyi Günler");
            }
            else
            {
                Console.WriteLine("iyi geceler");
            }

            string sonuc = time <= 18 ? "iyi günler" : "iyi geceler";
            sonuc = time >= 6 && time <= 11 ? "günaydın" : time <= 18 ? "iyi günler" : "iyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}
