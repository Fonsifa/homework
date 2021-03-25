using System;
public class Node<T>
{
    public Node<T> Next { get; set; }
    public T Data { set; get; }

    public Node(T t)
    {
        Next = null;
        Data = t;
    }
}
public class GenericList<T>
{
    public static int min_num = 1000000, max_num = -1000000, sum = 0;
    private Node<T> head, tail;
    public GenericList()
    {
        tail = head = null;
    }
    public Node<T> Head { get => head; }
    public Node<T> Tail { get => tail; }
    public void Add(T t)
    {
        Node<T> n = new Node<T>(t);
        if (tail == null)
        {
            head = tail = n;
        }
        else
        {
            tail.Next = n;
            tail = n;
        }
    }
    public static void ForEach(GenericList<T> t,Action<T> action)
    {
        Node<T> a = t.Head;
        while (a != null)
        {
            action(a.Data);
            a = a.Next;
        }
    }
}
public delegate int F(GenericList<int> t);


namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > GenericList<int>.max_num) GenericList<int>.max_num = x;
                if (x < GenericList<int>.min_num) GenericList<int>.min_num = x;
                GenericList<int>.sum += x;
                intlist.Add(x);
            }
            Action<int> ac = delegate (int i) { Console.WriteLine(i); };
            GenericList<int>.ForEach(intlist, ac);
            F minn = delegate (GenericList<int> t) { return GenericList<int>.min_num; };
            F maxn= delegate (GenericList<int> t) { return GenericList<int>.max_num; };
            F sumn=delegate(GenericList<int> t) { return GenericList<int>.sum; };
            Console.WriteLine($"最小值为{minn(intlist)}");
            Console.WriteLine($"最大值为{maxn(intlist)}");
            Console.WriteLine($"总和为{sumn(intlist)}");
        }
    }
}
