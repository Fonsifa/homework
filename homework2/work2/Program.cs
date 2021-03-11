using System;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            double ave;
            int max_num=0, min_num=100, sum = 0,n;
            Console.WriteLine("input the length of the array");
            n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            for (int i=0;i<n;i++)
            {
                a[i] = rnd.Next(100) + 1;
            }
            for(int i=1;i<n;i++)
            {
                sum += a[i];
                if (a[i] > max_num) max_num = a[i];
                if (a[i] < min_num) min_num = a[i];
            }
            ave = sum / n;
            Console.WriteLine($"average is {ave}");
            Console.WriteLine($"max number is {max_num}");
            Console.WriteLine($"min number is {min_num}");
            Console.WriteLine($"sum is {sum}");
        }
    }
}
