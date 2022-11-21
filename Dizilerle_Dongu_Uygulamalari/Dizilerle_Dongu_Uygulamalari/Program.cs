using System;

namespace Dizilerle_Dongu_Uygulamalari
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "eşek", "maymun", "kuş" };

            int[] dizi;
            dizi = new int[3];


            renkler[0] = "kırmızı";
            dizi[2] = 5;
            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(dizi[2]);
            Console.WriteLine(renkler[0]);
            Console.Write("Dizinin Uzunluğunu giriniz: ");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayi = new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.WriteLine("dizinin {0}. değerini giriniz: ", i + 1);
                sayi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var item in sayi)
            {
                toplam = toplam + item;
            }
            Console.WriteLine("Sayıların Ortalaması= " + toplam / sayi.Length);
        }
    }
}
