using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program
            Console.WriteLine("Bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

            // "a" dan "z" ye kadar tüm harfleri console a yazdır
            char character = 'a';
            while (character <= 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            Console.WriteLine("------------------------------------");

            string esyalar = "Masa, Sandalye, Sehpa, Koltuk";
            foreach (var item in esyalar)
            {
                Console.Write(item);
            }

        }
    }
}
