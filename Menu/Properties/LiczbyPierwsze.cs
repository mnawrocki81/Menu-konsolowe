using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Properties
{
    static class LiczbyPierwsze
    {
        static public bool CzyPierwsza(int n)
        {
            if (n < 2)
                return false; //gdy liczba jest mniejsza niż 2 to nie jest pierwszą

            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false; //gdy zostanie znaleziony dzielnik, to dana liczba nie jest pierwsza
            return true;

        }

        static public void CzynnikiPierwsze(int n)
        {
            int k = 2; //ustawiam k na pierwszą liczbę pierwszą

            if (n < -1)
            {

                n /= -1;
                Console.Write("-1, ");

            }

            else if (n == -1 || n == 0 || n == 1)
            {
                Console.WriteLine(" BRAK!");
            }

            while (n > 1)
            {
                while (n % k == 0) //dopóki liczba jest podzielna przez k
                {
                    Console.Write(k + ", ");
                    n /= k;
                }
                ++k;
            }


        }

        public static void Obliczenie()
        {

            int n;
            Console.WriteLine("Program do obliczania liczb pierwszych!" + Environment.NewLine);
            Console.Write("Podaj liczbe: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine +"Sprawdznia czy n jest liczbą pierwszą:" + Environment.NewLine);
            
            if (CzyPierwsza(n))
                Console.WriteLine("Liczba " + n + " JEST pierwsza");
            else
                Console.WriteLine("Liczba " + n + " NIE JEST pierwsza");

            
            Console.WriteLine(Environment.NewLine + "Rozkład liczby n na czynniki pierwsze:" + Environment.NewLine);

            Console.Write("Czynniki pierwsze liczby " + n + " = ");
            CzynnikiPierwsze(n);

            Console.ReadKey();
        }
    }
}
