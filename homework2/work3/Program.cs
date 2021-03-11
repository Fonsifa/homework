using System;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] is_prime = new bool[105];
            for (int i = 2; i <= 100; i++) is_prime[i] = true;
            for(int i=2;i*i<=100;i++)
            {
                for (int j = 2*i; j <= 100; j += i)
                    is_prime[j] = false;
            }
            for (int i = 2; i <= 100; i++)
            {
                if (is_prime[i]) Console.Write($"{i}  ");
            }
        }
    }
}
