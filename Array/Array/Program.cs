using System;

namespace Dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 23, 124, 12, 45, 1254, 12, 4, 124, 123 };
            Console.WriteLine("-----------Sırasız Dizi---------");
            DiziYazdir(dizi);

            Console.WriteLine("-----------Sıralı Dizi---------");
            Array.Sort(dizi);

            DiziYazdir(dizi);

            Console.WriteLine("-----------Array Clear ile eleman çıkarma---------");
            Array.Clear(dizi, 2, 2);
            DiziYazdir(dizi);

            Console.WriteLine("-----------Array Resize ile diziyi yeniden boyutlandırma---------");
            Array.Resize<int>(ref dizi, 3);
            DiziYazdir(dizi);

            Console.WriteLine("-----------Reverse ile diziyi ters çevirme---------");
            Array.Reverse(dizi);
            DiziYazdir(dizi);

            Console.WriteLine("-----------IndexOf ile dizi içindeki elemanın indexini getirme---------");
            Array.IndexOf(dizi, 45);
            



        }

        public static void DiziYazdir(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
