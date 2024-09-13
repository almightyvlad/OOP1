using System.Text;

namespace ConsoleApp1
{
    public static class SecondTask
    {
        public static void Types()
        {
            // a
            string str1 = "hello";
            string str2 = "hello";

            Console.WriteLine(String.Compare(str1, str2));

            Console.WriteLine("===================================================");

            // b

            string str3 = "around";
            string str4 = "the";
            string str5 = "fur";

            Console.WriteLine(String.Concat(str3, str4, str5));

            string str6 = String.Copy(str3);

            string str7 = "around-the-fur";

            string[] str8 = str7.Split("-");

            foreach (string str in str8)
            {
                Console.WriteLine(str);
            }

            // Выделение подстроки
            Console.WriteLine(str3.Substring(1, 3));

            Console.WriteLine(str3.Insert(1, "qwe"));

            Console.WriteLine(str3.Remove(1, 3));

            Console.WriteLine($"dsamdkmsalkmdsa {str3}");


            Console.WriteLine("===================================================");

            // c

            string str9 = null;
            string str10 = "";

            Console.WriteLine(String.IsNullOrEmpty(str9));

            Console.WriteLine(String.IsNullOrEmpty(str10));

            Console.WriteLine("===================================================");

            // d

            var str11 = new StringBuilder("qwerty");

            Console.WriteLine(str11.Append(23));

            Console.WriteLine(str11.Insert(1, "12"));

            Console.WriteLine(str11.Remove(3, 3));
        }
    }
}
