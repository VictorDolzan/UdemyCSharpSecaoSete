using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSete
{
    class TipoTimeSpan
    {
        public static void ExecutarTipoTimeSpan()
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(15, 13, 25, 30);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321 );

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine("TimeSpan basico t1: " + t1);
            Console.WriteLine("TimeSpan basico com Ticks t1: " + t1.Ticks);
            Console.WriteLine("TimeSpan basico em Long t2: " + t2);
            Console.WriteLine("TimesSpan basico passando h,m,s t3: " + t3);
            Console.WriteLine("TimeSpan basico passando d,h,m,s t4: " + t4);
            Console.WriteLine("TimeSpan basico passando d,h,m,s,ms t5: " + t5);
            Console.WriteLine("TimeSpan utilizando notação ponto 'FromDays' t6: " + t6);
            Console.WriteLine("TimeSpan utilizando notação ponto 'FromHours' t7: " + t7);
            Console.WriteLine("TimeSpan utilizando notação ponto 'FromMinutes' t8: " + t8);
            Console.WriteLine("TimeSpan utilizando notação ponto 'FromSeconds' t9: " + t9);
            Console.WriteLine("TimeSpan utilizando notação ponto 'FromMilliseconds' t10: " + t10);
            Console.WriteLine("TimeSpan utilizando notação ponto 'FromTicks' t11: " + t11);
        }
    }
}