using System;

namespace HM1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            char op;
            double a1,a2,ans = 0;
            Console.WriteLine("input 2 numbers and 1 operator:");
            s = Console.ReadLine();
            a1 = Double.Parse(s);
            s = Console.ReadLine();
            a2 = Double.Parse(s);
            s = Console.ReadLine();
            op = char.Parse(s);
            switch (op)
            {
                case '+':
                    ans = a1 + a2;break;
                case '-':
                    ans = a1 - a2;break;
                case '*':
                    ans = a1 * a2;break;
                case '/':
                    ans = a1 / a2;break;
                case '%':
                    ans = a1 % a2;break;
                default:
                    Console.WriteLine("input error");return;
            }
            Console.WriteLine($"answer is {ans}");
        }
    }
}
