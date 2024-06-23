using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDEmo;

class Program
{
    static void Main(string[] args)
    {
        var datetime=new DateTime(1970,6,15,13,13,00);
        Console.WriteLine(datetime);
        var now = DateTime.Now;
        Console.WriteLine(now);
        var today = DateTime.Today;
        Console.WriteLine(today);
        Console.WriteLine(today.Day);
        var tomorrow = today.AddDays(1);
        Console.WriteLine(tomorrow.ToShortDateString());
        var yesterday = today.AddDays(-1);
        Console.WriteLine(yesterday.ToLongDateString());
        Console.WriteLine(now.ToString("dd-MM-yyyy"));
        Console.WriteLine(now.ToString("D"));
        Console.WriteLine("\t\t\t\t\ttimespan");

        var timeSpan=new TimeSpan(1,2,0,0);
        Console.WriteLine("TotalHours:"+timeSpan.TotalHours);
        var timeSpan2 = tomorrow - yesterday;
        Console.WriteLine("tomorrow-yesterday:"+timeSpan2.Days);
        var timeSpan3 = TimeSpan.FromDays(4);
        Console.WriteLine("timespan of 4 days: "+timeSpan3);
        var timespan5=timeSpan3.Add(TimeSpan.FromDays(4));
        Console.WriteLine("timespan of 4 days: " + timeSpan3);
        Console.WriteLine("timespan5: " + timespan5.TotalDays);
        Console.WriteLine("timespan5 - 8 days: " + (timespan5.Subtract(TimeSpan.FromDays(8))).TotalDays);

        string ts = "3:59:0";
        var timespan6 = TimeSpan.Parse(ts);
        Console.WriteLine(timespan6.TotalMinutes+ " minutes in timespan");
    }
}