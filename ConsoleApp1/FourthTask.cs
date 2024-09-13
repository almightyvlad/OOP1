
namespace ConsoleApp1
{
    public static class FourthTask
    {
        public static void Tuples()
        {
            // a 
            (int, string, char, string, ulong) tuple = (1, "qwe", 'V', "ewq", 18446744073709551615);

            (int, string, char, string, ulong) tuple1 = (1, "qwe", 'V', "ewq", 18446744073709551615);


            // b
            Console.WriteLine(tuple);

            Console.WriteLine($"First: {tuple.Item1}, third: {tuple.Item3}, fourth: {tuple.Item4}");

            // c

            (int a, string b, _, string d, _) = tuple;

            int a1 = tuple.Item1;
            string b1 = tuple.Item2;
            char c1 = tuple.Item3;
            string d1 = tuple.Item4;
            ulong e1 = tuple.Item5;



            // d


            Console.WriteLine(tuple == tuple1);







        }
    }
}
