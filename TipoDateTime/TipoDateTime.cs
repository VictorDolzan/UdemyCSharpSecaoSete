using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSete
{
    class TipoDateTme
    {
        public static void ExecutarTipoDateTime()
        {
            //DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2020, 12, 28);
            DateTime d3 = new DateTime(2020, 12, 28, 10, 34, 15);
            DateTime d4 = new DateTime(2020, 12, 28, 10, 35, 23, 500 );

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;

            DateTime d8 = DateTime.Parse("2000-08-15");
            DateTime d9 = DateTime.Parse("2000-08-15 13:05:08");
            //DateTime d10 = DateTime.Parse("15/08/2000", CultureInfo.InvariantCulture);

            DateTime d11 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15-08-2000 13:05:34", "dd-MM-yyyy HH:mm:ss", CultureInfo.CurrentCulture);
            

            // Console.WriteLine("Date time Now: " + d1);
            // Console.WriteLine("Date time Now ticks: " + d1.Ticks);

            Console.WriteLine("Construtor d2: " + d2);
            Console.WriteLine("Construtor d3 com minutos: " + d3);
            Console.WriteLine("Construtor d4 com milisegundos: " + d4);
            Console.WriteLine("Construtor d5 Date Time Now: " + d5);
            Console.WriteLine("Date Time Today d6: " + d6);
            Console.WriteLine("Date time UTC Now d7: " + d7);
            Console.WriteLine("Date Time Parse d8: " + d8);
            Console.WriteLine("Date Time Parse com horas d9: " + d9);
            //Console.WriteLine("Date Time Parse Brasil d10: " + d10);
            Console.WriteLine("Date Time Parse Exact d11: " + d11);
            Console.WriteLine("Date Time Parse Exact d12: " + d12);
        }
    }
}