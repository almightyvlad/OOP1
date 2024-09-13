
using ConsoleApp1;


class Programm
{

    static void FirstFunction()
    {

    }
    static void Main(string[] args)

    {

        //FirstTask.Strings();

        //SecondTask.Types();

        //ThirdTask.Arrays();

        //FourthTask.Tuples();

        // 5

        int[] arr = { 10, 20, 30, 40, 50 };

        string str = "hello world";

        (int maxElement, int minElement, int sum, char firstLetter) LocalFunc(int[] arr, string str)
        {
            int maxElement = arr.Max();
            int minElement = arr.Min();

            int sum = arr.Sum();

            char firstLetter = str[0];

            return (maxElement, minElement, sum, firstLetter);
        }

        var result = LocalFunc(arr, str);

        Console.WriteLine(result);

        // 6

        void LocalFunc1()
        {
            checked
            {
                int number = int.MaxValue;
            }
        }

        void LocalFunc2()
        {
            unchecked
            {
                int number = int.MaxValue + 1;
            }
        }

        LocalFunc1();
        LocalFunc2();





    }

}