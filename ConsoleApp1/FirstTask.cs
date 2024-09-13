

namespace ConsoleApp1
{
    public static class FirstTask
    {
        public static void Strings()
        {
            // a
            bool a = true;

            byte b = 255;

            sbyte c = 127;

            char d = 'd';

            decimal e = 5E5m;

            double f = 6.32131321;

            float g = 5.313232f;

            int i = 228;

            uint j = 1543462346;

            nint k = 32132132;

            nuint l = 321243214;

            long m = 9223372036854775807;

            ulong n = 18446744073709551615;

            short s = 32767;

            ushort t = 65535;


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(s);
            Console.WriteLine(t);

            Console.WriteLine("===================================================");

            // b


            //Console.WriteLine(Convert.ToInt16(a));
            //Console.WriteLine(Convert.ToInt32(b));

            //Console.WriteLine(Convert.ToDouble(c));

            //Console.WriteLine(int.Parse("54543"));

            //Console.WriteLine(double.Parse("41"));

            float a1 = 10.5f;
            int a2 = (int)a1;

            double b1 = 9.8;
            float b2 = (float)b1;

            long c1 = 10000000000;
            int c2 = (int)c1;

            object d1 = "Hello world";
            string d2 = (string)d1;

            int e1 = 300;
            byte e2 = (byte)e1;

            int a3 = 100;
            long a4 = a3;

            char b3 = 'A';
            int b4 = b3;

            float c3 = 5.5f;
            double c4 = c3;

            byte d3 = 120;
            int d4 = d3;

            int e3 = 200;
            double e4 = e3;

            // c

            int num = 1;
            object boxing = num;
            int unboxing = (int)boxing;

            // d

            var ab = "Hello world";
            Console.WriteLine(ab.GetType());

            // e 

            int? ran = null;

            Console.WriteLine(ran);

            // f 

            //var qwe = 'A';
            //qwe = 4;
        }

    }
}
