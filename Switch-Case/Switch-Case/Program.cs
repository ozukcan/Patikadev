using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Month;

            switch (time)
            {
                case 1:
                    Console.WriteLine("Ocak Ayı!");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayı!");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayı!");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayı!");
                    break;
                case 5:
                    Console.WriteLine("Mayıs Ayı!");
                    break;
                case 6:
                    Console.WriteLine("Haziran Ayı!");
                    break;
                case 7:
                    Console.WriteLine("Temmuz Ayı!");
                    break;
                case 8:
                    Console.WriteLine("Ağustos Ayı!");
                    break;
                case 9:
                    Console.WriteLine("Eylül Ayı!");
                    break;
                case 10:
                    Console.WriteLine("Ekim Ayı!");
                    break;
                case 11:
                    Console.WriteLine("Kasım Ayı!");
                    break;
                case 12:
                    Console.WriteLine("Aralık Ayı!");
                    break;

                default:
                    break;
            }
            switch (time)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındayız!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahardayız!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yazdayız!");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahardayız!");
                    break;

                default:
                    break;
            }
        }
    }
}
