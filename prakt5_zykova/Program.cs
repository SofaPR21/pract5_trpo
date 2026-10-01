using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt5_zykova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 0;

            while (n == 0 || n < 0)
            {
                Console.WriteLine("Число не может быть отрицательным или равно 0! Введите n: ");
                n = int.Parse(Console.ReadLine());
            }

            int res = n;
            while (res % 7 != 0)
            {
                n1 = n % 10;
                n2 = n / 10;
                res = n1 * 100 + n2;

                if (res == n)
                    break;
            }

            if (res % 7 == 0)
            {
                Console.WriteLine("Число, делимое на 7 = " + res);
            }
            else
            {
                Console.WriteLine("не делится, вернулись к " + n);
            }
            
        }
    }
}
