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
            int Nostatok = 0;
            int Nneostatok = 0;
            int res = n;

            while (n == 0 || n < 0)
            {
                Console.WriteLine("Число не может быть отрицательным или равно 0! Введите n: ");
                n = int.Parse(Console.ReadLine());
            }

            while (res % 7 != 0)
            {
                Nostatok = res % 10;
                Nneostatok = res / 10;

                for (int i = Nneostatok; i > 0;)
                {
                    i = i / 10;
                    Nostatok *= 10;
                }

                res = Nostatok + Nneostatok;

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
