using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSete
{
    class PropriedadesEOperacoesTimeSpan
    {
        public static void ExecutarPropriedadesEOperacoesTimeSpan()
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine("MaxValue do t1: " + t1);
            Console.WriteLine("MinValue do t2: " + t2);
            Console.WriteLine("ZeroValue do t3: " + t3);
            Console.WriteLine();

            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine("TimeSpan t4: " + t4);

            Console.WriteLine("Days: " + t4.Days);
            Console.WriteLine("Hours: " + t4.Hours);
            Console.WriteLine("Minutes: " + t4.Minutes);
            Console.WriteLine("Seconds: " + t4.Seconds);
            Console.WriteLine("Milliseconds: " + t4.Milliseconds);
            Console.WriteLine("Ticks: " + t4.Ticks);
            Console.WriteLine();
            
            Console.WriteLine("Total Days: " + t4.TotalDays);
            Console.WriteLine("Total Hours: " + t4.TotalHours);
            Console.WriteLine("Total Minutes: " + t4.TotalMinutes);
            Console.WriteLine("Total Seconds: " + t4.TotalSeconds);
            Console.WriteLine("Total Milliseconds: " + t4.TotalMilliseconds);
            Console.WriteLine();

            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);

            TimeSpan tSum = t5.Add(t6);
            TimeSpan tDif = t5.Subtract(t6);
            TimeSpan tMult = t6.Multiply(2.0);
            TimeSpan tDiv = t6.Divide(2.0);

            Console.WriteLine("Operações TimeSpan: ");
            Console.WriteLine("Operação Sum(t5 + t6): " + tSum);
            Console.WriteLine("Operação Subtract(t5 - t6): " + tDif);
            Console.WriteLine("Operação Multiply(t6 * 2.0): " + tMult);
            Console.WriteLine("Operação Divide(t6 / 2.0): " + tDiv);


        }
    }
}