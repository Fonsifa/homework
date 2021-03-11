using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 2; i <= n; i++)
                {
                    while (n != i)     //若i=n，则质因数就是n本身  
                    {
                        if (n % i == 0)  //若i是质因数，则打印出i的值，并用商给n赋新值  
                        {
                        Console.WriteLine(i);
                            n = n / i;
                        }
                        else break;//若不能被i整除，则算下一个i  
                    }
                }
            Console.Write(n);
        }
    }
}
