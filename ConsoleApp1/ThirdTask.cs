using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ThirdTask
    {
        public static void Arrays()
        {
            // a

            int[,] arr1 = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };

            int height = arr1.GetLength(0); // 1 измерение
            int width = arr1.GetLength(1);  // 2 измерение

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }

                Console.WriteLine();   
            }

            // b

            string[] arr2 = { "around", "the", "fur" };

            foreach (string str in arr2)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(arr2.Length);

            Console.WriteLine("Введите индекс элемента, который хотите изменить: ");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите на что вы хотите заменить элемент: ");

            string replacement = Console.ReadLine();

            arr2[choice] = replacement;

            foreach (string str in arr2)
            {
                Console.WriteLine(str);
            }

            // c

            double[][] arr3 = new double [3][];

            arr3[0] = new double[2];
            arr3[1] = new double[3];
            arr3[2] = new double[4];


            for (int i = 0; i < 2; i++)
            {
                arr3[0][i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                arr3[1][i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                arr3[2][i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    Console.Write(arr3[i][j] + " ");
                }
                Console.WriteLine();
            }

            // d

            var arr4 = new[] { 1, 2, 3 };

            var newStr = "dsadsadas";



        }
    }
}
