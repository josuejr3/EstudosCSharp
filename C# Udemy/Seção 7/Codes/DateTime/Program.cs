using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);


            // Construtor - Somente Data
            DateTime d2 = new DateTime(2026, 02, 16);
            Console.WriteLine(d2);
            // Construtor - Data e Hora
            DateTime d3 = new DateTime(2026, 02, 16, 15, 30, 15);
            Console.WriteLine(d3);

            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.UtcNow);


            DateTime d4 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d4);

            DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine("===================================================");

            TimeSpan t11 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t11);
            Console.WriteLine(t11.Ticks);

            Console.WriteLine("Construtores");
            TimeSpan t22 = new TimeSpan();           // cria um timespan com a duração 0
            Console.WriteLine(t22);


            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 400);
            Console.WriteLine(t5);


            // Criando timespan equivalente a um dia e meio
            TimeSpan ts = TimeSpan.FromDays(1.5);
            Console.WriteLine(ts);

            TimeSpan tss = TimeSpan.FromHours(1.5);
            Console.WriteLine(tss);


            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);

            Console.WriteLine("===================================================");
            Console.WriteLine($"Date: {d.Date}");
            Console.WriteLine($"Day: {d.Day}");
            Console.WriteLine($"DayOfWeek: {d.DayOfWeek}");
            Console.WriteLine($"Hour: {d.Hour}");
            Console.WriteLine($"Kind: {d.Kind}");
            Console.WriteLine($"Millisecond: {d.Millisecond}");
            Console.WriteLine($"Minute: {d.Minute}");
            Console.WriteLine($"Month: {d.Month}");
            Console.WriteLine($"Second: {d.Second}");
            Console.WriteLine($"Ticks: {d.Ticks}");
            Console.WriteLine($"TimeOfDay: {d.TimeOfDay}");
            Console.WriteLine($"Year {d.Year}");


            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());


            Console.WriteLine(d.AddHours(2));  
            Console.WriteLine(d.Subtract(new DateTime(2000, 10, 10)));

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2);
            TimeSpan div = t2.Divide(2);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);


            DateTime novaData = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime outraData = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime outraData2 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine($"data: {novaData}");
            Console.WriteLine($"data kind: {novaData.Kind}");
            Console.WriteLine($"data para local: {novaData.ToLocalTime()}");
            Console.WriteLine($"data para utc: {novaData.ToUniversalTime()}");


        }
    }
}