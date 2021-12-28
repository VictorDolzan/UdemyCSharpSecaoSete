using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSete
{
    class PropriedadesEOperacoesDateTime
    {
        public static void ExecutarPropriedadesEOperacoesDateTime()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);
            

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) Day of the week: " + d.DayOfWeek);
            Console.WriteLine("4) Day of the Year: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) Time of the Day: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine();

            string s1 = d2.ToLongDateString();
            string s2 = d2.ToLongTimeString();
            string s3 = d2.ToShortDateString();
            string s4 = d2.ToShortTimeString();
            string s5 = d2.ToString();

            string s6 = d2.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d2.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine("1)To Long Date String d2 usando variavel s1: " + s1);
            Console.WriteLine("2)To Long Time String d2 usando variavel s2: " + s2);
            Console.WriteLine("3)To Short Date String d2 usando variavel s3: " + s3);
            Console.WriteLine("4)To Short Date String d2 usando variavel s4: " + s4);
            Console.WriteLine("5)To String d2 usando variavel s5: " + s5);
            Console.WriteLine("6)To String editando mascara d2 usando variavel s6: " + s6);
            Console.WriteLine("7)To String editando mascara2 d2 usando variavel s7: " + s7);
            Console.WriteLine();


            DateTime d3 = DateTime.Now;
            DateTime d4 = d3.AddHours(2);
            DateTime d5 = d3.AddMinutes(3);
            DateTime d6 = d3.AddDays(7);

            Console.WriteLine("Operações com DateTime: ");
            Console.WriteLine("DateTime antes de adicionar hora: " + d3);
            Console.WriteLine("DateTime após adicionar horas: " + d4);
            Console.WriteLine("DateTime após adicionar minutos: " + d5);
            Console.WriteLine("DateTime após adicionar 7 dias: " + d6);
            Console.WriteLine();

            DateTime d7 = new DateTime(2000, 10, 15);
            DateTime d8 = new DateTime(2000, 10, 18);

            TimeSpan ts = d8.Subtract(d7);

            Console.WriteLine("A diferença entre d8 e d7 é de: " + ts + " dias;");
            
        }
    }
}