using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSete
{
    class SintaxeSwitchCase
    {
        public static void ExecutarSintaxeSwitchCase()
        {
            Console.WriteLine("Digite um número inteiro de 1 até 7: ");
            int num = int.Parse(Console.ReadLine());
            string day;
            
            switch(num){
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day é: " + day);

        }
    }
}