using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;

            Console.WriteLine("Lütfen haftanın günlerine dair bir sayi girin : ");
            day = Convert.ToInt16(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Pazartesi"); break;
                case 2: Console.WriteLine("Salı"); break;
                case 3: Console.WriteLine("Carsamba"); break;
                case 4: Console.WriteLine("Persembe"); break;
                case 5: Console.WriteLine("Cuma"); break;
                case 6: Console.WriteLine("Cumartesi"); break;
                case 7: Console.WriteLine("Pazar"); break;
                default: Console.WriteLine("Yanlıs bir sayı girdiniz"); break;
            }



            Console.Read();
        }
    }
}
