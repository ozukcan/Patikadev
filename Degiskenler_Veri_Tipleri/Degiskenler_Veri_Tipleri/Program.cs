using System;

namespace Degiskenler_Veri_Tipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string deger = null;
            Console.WriteLine(deger);


            byte b = 5; //0-255 1byte
            sbyte a = 5; //-128 - +127 1byte
            short s = 5; //-32.000 - +32.000 2byte
            ushort u = 5;//0 -  65365 2byte

            Int16 i16 = 2; // 2byte
            int i = 2; //4 byte
            Int32 i32 = 2; //4byte
            Int64 i64 = 2; //8 byte
            uint ui = 2; //4byte
            long l = 2; //8byte
            ulong r = 2; //8byte

            float f = 5; //4byte
            double d = 5.4; //8byte

            char c = 'a'; //2byte
            string str1 = "Hüseyin";

            bool bl = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";//string
            object o2 = 'y';//char
            object o3 = 4.5;
            object o4 = 6;

            string str = string.Empty;
            str = "Hüseyin Özükcan";
            string ad = "Hüseyin";
            string soyad = "Özükcan";
            string tam_ad = ad + " " + soyad;

            int int1 = 5;
            int int2 = 3;
            int in3 = int1 * int2;

            bool b1 = 10 > 2;

            string str20 = "20";
            int int20 = 20;
            string str3 = str20 + int20.ToString();
            Console.WriteLine(str3);

            int int3 = int20 + Convert.ToInt32(str20);

            Console.WriteLine(int3);

            int int4 = int20 + int.Parse(str20);
            Console.WriteLine(int4);

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyyy");
            Console.WriteLine(datetime1);
            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);
        }
    }
}
