using System;

namespace work4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[100, 100];
            int m, n;
            bool ans = true;
            Console.WriteLine("input the number of rows:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the number of lines:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the number (row first):");//行优先输入
            for(int j=0;j<m;j++)
                for(int i=0;i<n;i++)
                {
                    mat[j,i] = Convert.ToInt32(Console.ReadLine());
                }
            for (int j = 1; j < m; j++)
                for (int i = 1; i < n; i++)
                    if (mat[j - 1, i - 1] != mat[j, i])
                    {
                        ans = false;break;
                    }
            if (ans) Console.WriteLine("it is a toplizer");
            else Console.WriteLine("no");
        }
    }
}
