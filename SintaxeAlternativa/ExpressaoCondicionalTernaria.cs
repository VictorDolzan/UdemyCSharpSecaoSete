using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSete
{
    class ExpressaoCondicionalTernaria
    {
        public static void ExecutarExpressaoCondicionalTernaria()
        {
            Console.WriteLine("Digite um preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
           
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;          

            Console.WriteLine(preco - desconto);


        }
    }
}