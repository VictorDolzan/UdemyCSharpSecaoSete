using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSete
{
    class TipoDateTimeKind
    {
        public static void ExecutarTipoDateTimeKind()
        {
            DateTime d1 = new DateTime(200, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("DateTimeKind d1: " + d1);
            Console.WriteLine("DateTimeKind d1.Kind: " + d1.Kind);
            Console.WriteLine("DateTimeKind d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("DateTimeKind d1 to UTC: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("DateTimeKind d2: " + d2);
            Console.WriteLine("DateTimeKind d2.kind: " + d2.Kind);
            Console.WriteLine("DateTimeKind d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("DateTimeKind d2 to UTC: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("DateTimeKind d3: " + d3);
            Console.WriteLine("DateTimeKind d3.Kind: " + d3.Kind);
            Console.WriteLine("DateTimeKind d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("DateTimeKind d3 to UTC: " + d3.ToUniversalTime());
            Console.WriteLine("ISO 8601: " + d3.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}