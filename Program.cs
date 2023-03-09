using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[6];
            //for (int i=0; i<6; i++)
            //{
            //    Console.WriteLine($"array[{i}]={array[i]}");

            //int[] array = new int[12];
            //Random ind = new Random();
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.WriteLine($"array[{i}]");
            //    array[i] = ind.Next(163, 190);
            //}
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //Console.Write("n=");
            //byte n = byte.Parse(Console.ReadLine());
            //double[] array = new double[n];
            //Random ind = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = -50 + 100 * ind.NextDouble();
            //    Console.WriteLine($"array[{i}]={i}");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"array[0] ={array[0]}\narray[n-1}] ={array[n-1]}");

            int[] array = new int[] { 37, 0, 50, 46, 0, 13 };
            foreach (int element in array)
            {
                Console.Write($"{element}\n");
            }
        }
    }
}
