using System;

namespace Tip_Donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Inplicit Conversion ***");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("int d: " + d);

            long h = d;
            Console.WriteLine("long h: " + h);

            float i = h;
            Console.WriteLine("float i: " + i);

            string e = "Seyf";
            char f = 'a';
            object g = e + f + d;
            Console.WriteLine("object g: " + g);


            // Explicit Conversion
            Console.WriteLine("*** Explicit Conversion ***");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("byte y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("byte t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("byte v: " + v);


            // ToString Method
            Console.WriteLine("*** ToString Method ***");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("string yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("string zz: " + zz);


            // System.Convert
            Console.WriteLine("*** System.Convert ***");

            string str1 = "10", str2 = "20";
            int num1, num2;
            int Sum;

            num1 = Convert.ToInt32(str1);
            num2 = Convert.ToInt32(str2);

            Sum = num1 + num2;
            Console.WriteLine("int Sum: " + Sum);


            // Parse
            Console.WriteLine("*** Parse ***");

            ParseMethod();

            static void ParseMethod()
            {
                string str1 = "11";
                string str2 = "62.58";
                int num1;
                double double1;

                num1 = Int32.Parse(str1);
                Console.WriteLine("int num1: " + num1);

                double1 = Double.Parse(str2);
                Console.WriteLine("double double1: " + double1);

            }
        }
    }
}
