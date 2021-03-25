using System;
public delegate void AlarmHandler(object sender, AlarmEvents args);
public class AlarmEvents
{
    public int time_now { set; get; }
    public int alrmTime { set; get; }
}

public class Clock
{ 
    //public int Alarm_Time { set; get; }
    //public int time_now { set; get; }
    //public Clock(int x,int y)
    //{
    //    time_now = x;
    //    Alarm_Time = y;
    //}
    public event AlarmHandler TICK, ALARM;
    public void Tick(int time_now,int Alarm_Time)
    {
        Console.WriteLine($"现在的时间是{time_now}");
        AlarmEvents args = new AlarmEvents() { time_now = time_now, alrmTime = Alarm_Time };
        TICK(this, args);
    }
    public void Alarm(int time_now, int Alarm_Time)
    {
        Console.WriteLine($"现在的时间是{time_now}");
        AlarmEvents args = new AlarmEvents() { time_now = time_now, alrmTime = Alarm_Time };
        ALARM(this, args);
    }
}
class Form
{
    public Clock c=new Clock();
    public Form()
    {
        c.TICK += new AlarmHandler(clock_tick);
        c.ALARM += new AlarmHandler(clock_alarm);
    }
    void clock_tick(object sender,AlarmEvents args)
    {
        Console.WriteLine($"tick tick");
    }
    void clock_alarm(object sender, AlarmEvents args)
    {
        Console.WriteLine($"alarm alarm");
    }
}

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            int time_now = 100, Alarm_Time = 1000;
            while(true)
            {
                if(time_now<Alarm_Time)
                form1.c.Tick(time_now, Alarm_Time);
                else
                {
                    form1.c.Alarm(time_now, Alarm_Time);
                    if ((time_now - Alarm_Time) >= 10) break;
                }
                time_now++;
            }
        }
    }
}
