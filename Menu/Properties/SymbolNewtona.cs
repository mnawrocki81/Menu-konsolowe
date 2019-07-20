using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Properties
{


    static class SymbolNewtona
    { 
        public static ulong TrojkatPascala(int n, int k)
        {
            ulong Wynik = 1;
            int i;

            if (k == 0 || n == k) Wynik = 1;

            for (i = 1; i <= k; i++)
            {
                Wynik = Wynik * (ulong)(n - i + 1) / (ulong)i;      // Obliczanie ze wzoru iteracyjnego
            }

            return Wynik;
        }

        public static void Obliczenie()
        {

            Console.WriteLine("Program do obliczenia wzoru dwumianowego Newtona!" + Environment.NewLine +"W pierwszej funkcji TrojkatPascala program wyznacza wartości Symbolu Newtona (nk) , który oblicza się jako n! /k!*(n-k)! "
                + Environment.NewLine + "gdzie w trójkącie Pascala n oznacza wiersz, k zaś pozycję od 0 do n, " +
                Environment.NewLine + "dla przykładu dla n=5 i k=2, symbol Newtona wynosi 10, dla k=15 i n=7, będzie to 6435"
                + Environment.NewLine + "Wyznaczenie odbywa się w sposób iteracyjny, który opiera się na założeniu o występowaniu czynników pierwszych w ciągach kolejnych liczb. " +
                Environment.NewLine + "Dla k = 0 i k = n, w trójkącie zawsze jest 1, kolejne wartości funkcja wyznacza korzystając z pętli i zwracając wynik." +
               Environment.NewLine + " Wynik jest typu ulong,gdyż wartości w Trójkącie Pascala są zawsze dodatnie i dzięki temu można wyznaczyć więcej wartości." +
               Environment.NewLine + "Następnie, po podaniu identyfikatorów a i b, oraz wykładnika n, " +
               Environment.NewLine + "program oblicza korzystając z pętli for od k=0 do k<=n wartość (a+b)n korzystając z wzoru dwumianowego Newtona" +
               Environment.NewLine + "");
            Console.Write("Podaj identyfikator a: ");
            string a = Console.ReadLine();
            Console.Write("Podaj identyfikator b: ");
            string b = Console.ReadLine();
            Console.Write("Podaj wykładnik n: ");
            int n = int.Parse(Console.ReadLine());

            int k;
            Console.WriteLine();

            Console.Write("Wypisanie wzoru dwumianowego Newtona: (" + a + " + " + b + ")^" + n + " = ");


            for (k = 0; k <= n; k++)
            {
                if (k == 0)
                {

                    Console.Write(a + "^" + (n - k));

                }
                if (k == 1)
                {

                    Console.Write(" + " + TrojkatPascala(n, k) + "*" + a + "^" + (n - k) + "*" + b);

                }


                if (n > 1 && k > 1 && k < n - 1)
                    Console.Write(" + " + TrojkatPascala(n, k) + "*" + a + "^" + (n - k) + "*" + b + "^" + k);


                if (n > 2 && k == (n - 1))
                {

                    Console.Write(" + " + TrojkatPascala(n, k) + "*" + a + "*" + b + "^" + k);

                }

                if (n > 1 && k == n)
                {

                    Console.WriteLine(" + " + b + "^" + k);

                }

            }

            Console.ReadKey();

        }
        
    }
}
