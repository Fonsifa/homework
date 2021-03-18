using System;

namespace homework3
{
    abstract class figure
    {
        abstract public double Get_Area();
        abstract public bool Is_leagal();
    }
    class square : figure
    {
        private double x;
        public square(double x)
        {
            this.x = x;
        }
        public override double Get_Area()
        {
            return x * x;
        }
        public override bool Is_leagal()
        {
            return (x > 0) ? true : false;
        }
    }
    class rectangle : figure
    {
        private double x, y;
        public rectangle(double x,double y)
        {
            this.x = x;this.y = y;
        }
        public override double Get_Area()
        {
            return x * y;
        }
        public override bool Is_leagal()
        {
            if (x * y < 0) return false;
            return true;
        }
    }

    class triangle : figure
    {
        private double x, y, z;
        public triangle(double x,double y,double z)
        {
            this.x = x;this.y = y;this.z = z;
        }
        public override double Get_Area()
        {
            double p = (this.x + this.y + this.z) / 2;
            return Math.Sqrt(p * (p - this.x) * (p - this.y) * (p - this.z));
        }
        public override bool Is_leagal()
        {
            if ((x + y - z) * (x + z - y) * (y + z - x) > 0) return true;
            return false;
        }
    }

    class factory
    {
        private static double All_area=0;
        private static int Wrong;
        public static double Get_All() { return All_area; }
        public static int Get_Wrong() { return Wrong; }
        public static void make_figure(int type)
        {
            Random rd = new Random();
            if (type == 1)
            {
                double x = rd.Next(1000) + 1;
                square s = new square(x);
                if (s.Is_leagal()) All_area += s.Get_Area();
                else Wrong++;
            }
            else if (type == 2)
            {
                double x = rd.Next(1000) + 1;
                double y = rd.Next(1000) + 1;
                rectangle s = new rectangle(x, y);
                if (s.Is_leagal()) All_area += s.Get_Area();
                else Wrong++;
            }
            else
            {
                double x = rd.Next(1000) + 1;
                double y = rd.Next(1000) + 1;
                double z = rd.Next(1000) + 1;
                triangle s = new triangle(x, y, z);
                if (s.Is_leagal()) All_area += s.Get_Area();
                else Wrong++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            for (int i=1;i<=10;i++)
            {
                factory.make_figure(rd.Next(3)+1);
            }
            Console.WriteLine($"总面积是{factory.Get_All()}");
            Console.WriteLine($"共{factory.Get_Wrong()}个图形不合法");
        }
    }
}
