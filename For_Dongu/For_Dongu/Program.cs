using System;

namespace For_Dongu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            int tektoplam = 0, cifttoplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tektoplam += i;
                }
                else
                {
                    cifttoplam += i;
                }

            }
            Console.WriteLine("Tek sayıların toplamı: " + tektoplam);
            Console.WriteLine("Çift sayıların toplamı: " + cifttoplam);

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
