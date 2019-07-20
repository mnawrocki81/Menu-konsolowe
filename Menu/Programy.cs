using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Programy
    {

        public static void BMI()
        {

            Console.WriteLine("Program do oblicznia współczynnika BMI");
            Console.Write("Podaj swoją wagę w kilogramach: ");
            double w = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj swój wzrost w centymetrach: ");
            double m = Convert.ToDouble(Console.ReadLine()) / 100;

            double bmi = w / (m * m);
            Console.WriteLine("Twoje BMI wynosi {0:F2}", bmi);

            if (bmi < 18.5)
                Console.WriteLine("Masz niedowagę");

            else if ((bmi >= 18.5) && (bmi <= 24.99))
                Console.WriteLine("Waga prawidłowa");

            else Console.WriteLine("Masz nadwagę");

            Console.ReadKey();
        }

        public static void Kalkulator()
        {

            Console.WriteLine("Prosty kalkulator z podstawowymi operacjami na dwóch liczbach");
            Console.Write("Podaj pierwszą liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj znak operacji: ");
            string sign = Console.ReadLine();
            double wynik = 0.0;

            switch (sign)
            {
                case "+":
                    wynik = a + b;
                    break;

                case "-":
                    wynik = a - b;
                    break;

                case "*":
                    wynik = a * b;
                    break;

                case "/":

                    if (b == 0) Console.WriteLine("Tej operacji nie można wykonać");
                    wynik = a / b;
                    break;

                default:
                    Console.WriteLine("Podano nieobsługiwany symbol!");
                    break;

            }

            Console.WriteLine("Wynik operacji: {0}", wynik);
            Console.ReadKey();

        }

        public static void LiczbyDoskonale()
        {

            Console.WriteLine("Program do wyznaczania liczb doskonałych");
            Console.Write("Podaj liczbę całkowitą większą od 0: ");
            int n = int.Parse(Console.ReadLine());

            if (n >5)
            {
                for (int i = 1; i <= n; i++)
                {
                    int suma = 0;

                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                            suma += j;
                    }
                    if (i == suma)
                        Console.WriteLine("{0} jest liczbą doskonałą w przedziale <1,{1}> ", i, n);
                }
            }

            else Console.WriteLine("Nie ma liczb doskonałych w przedziale <1,{0}> ", n);

            Console.ReadKey();
        }

        public static void CelsjuszToFahrenheit()
        {

            Console.WriteLine("Przeliczanie ze stopni Celsjusza na stopnie Fahrenheita");
            Console.WriteLine();
            Console.Write("Podaj temperature w stopniach Celsjusza: ");
            double c = double.Parse(Console.ReadLine());

            double f = 32 + (9.0 / 5 * c);

            Console.WriteLine("Temperatura w stopniach Fahrenheita wynosi {0}", f);
            Console.ReadKey();
        }

        public static void FahrenheitToCelsjusz()
        {

            Console.WriteLine("Przeliczanie ze stopni Fahrenheita na stopnie Celsjusza");
            Console.WriteLine();
            Console.Write("Podaj temperature w stopniach Fahrenheita: ");
            double fah = double.Parse(Console.ReadLine());

            double c = (fah - 32) * (5.0 / 9);

            Console.WriteLine("Temperatura w stopniach Celsjusza wynosi {0:F3}", c);

            Console.ReadKey();

        }

        public static void PrzeliczanieTemperatur()
        {
            Console.WriteLine("Program do przeliczania z Celsjusza na Fahrenheita i na odwrót");
            Console.WriteLine();
            Console.WriteLine("Chcesz przeliczyć stopnie:  \n1. Celsjusza na Fahrenheita?,\n2. Fahrenheita na Celsjusza?");
            Console.WriteLine();
            Console.WriteLine("Naciśnij klawisz: 1 lub 2");
            ConsoleKeyInfo klawisz = Console.ReadKey();

            Console.WriteLine();
            switch (klawisz.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    CelsjuszToFahrenheit();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    FahrenheitToCelsjusz();
                    break;
                
            }


            Console.ReadKey();


        }
        public static ulong Fib_rek(int wyraz)
        {
            if (wyraz == 0 || wyraz == 1) return (ulong)wyraz;
            else return Fib_rek(wyraz - 1) + Fib_rek(wyraz - 2);
        }

        public static ulong Fib_it(int wyraz)
        {
            if (wyraz == 0 || wyraz == 1) return (ulong)wyraz;
            else
            {
                ulong fib0 = 0;
                ulong fib1 = 1;
                ulong fib = 0;

                for (int i = 2; i <= wyraz; i++)
                {

                    fib = fib0 + fib1;
                    fib0 = fib1;
                    fib1 = fib;

                }
                return fib;
            }
        }

        public static void LiczbyFibonacciego()
        {

            Console.WriteLine("Program do wyznaczania liczb Fibonacciego");
            Console.Write("Podaj n-ty wyraz ciągu Fibonacciego, ktory chcesz obliczyć: ");
            int n = int.Parse(Console.ReadLine());

           
            Console.WriteLine("Obliczamy: \n1. rekurencyjnie,\n2. iteracyjnie, \n3. na dwa sposoby? \nNaciśnij klawisz: 1,2 lub 3");

            ConsoleKeyInfo klawisz = Console.ReadKey();

            Console.WriteLine();
            switch (klawisz.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("N-ty wyraz ciągu Fibonacciego - obliczony rekurencyjnie -  wynosi {0}", Fib_rek(n));
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("N-ty wyraz ciągu Fibonacciego - obliczony iteracyjnie -  wynosi {0}", Fib_it(n));
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("N-ty wyraz ciągu Fibonacciego - obliczony rekurencyjnie -  wynosi {0}", Fib_rek(n));
                    Console.WriteLine("N-ty wyraz ciągu Fibonacciego - obliczony iteracyjnie -  wynosi {0}", Fib_it(n));
                    break;

            }
            

            Console.ReadKey();

        }

        public static void JakiMiesiąc()
        {
            Console.WriteLine("Program, który przypomina, jaki jest obecnie miesiąc ;)");
            Console.WriteLine();

            DateTime date = DateTime.Now;
            string dt = String.Format("{0:dd-MM-yyyy}", date);
            string month = dt.Substring(3, 2);

            Console.Write("Jakbyś przypadkiem zapomniał...  to mamy teraz miesiąc: ");
            if (month == "01")
                Console.WriteLine("Styczeń");
            else if (month == "02")
                Console.WriteLine("Luty");
            else if (month == "03")
                Console.WriteLine("Marzec");
            else if (month == "04")
                Console.WriteLine("Kwiecień");
            else if (month == "05")
                Console.WriteLine("Maj");
            else if (month == "06")
                Console.WriteLine("Czerwiec");
            else if (month == "07")
                Console.WriteLine("Lipiec");
            else if (month == "08")
                Console.WriteLine("Sierpień");
            else if (month == "09")
                Console.WriteLine("Wrzesień");
            else if (month == "10")
                Console.WriteLine("Październik");
            else if (month == "11")
                Console.WriteLine("Listopad");
            else if (month == "12")
                Console.WriteLine("Grudzień");

            Console.ReadKey();
        }

        public static void Palindrom()
        {
            Console.WriteLine("Program do sprawdzania czy słowo/zdanie jest palindromem");
            Console.WriteLine("Palindrom - wyrażenie brzmiące tak samo czytane od lewej do prawej i od prawej do lewej.");
            Console.Write("\nPodaj wyrażenie: ");
            string n =Console.ReadLine();
            
             string signsToTrim = ",.;:-!?'\" ";
             for (int i = 0; i < signsToTrim.Length; i++)
             {
                 n = n.Replace(signsToTrim[i].ToString(), "");
             }

            n = n.ToUpper();
            
            bool palindrom = true;

            for (int i = 0; i < n.Length/2; i++)
            {
                
                if (!n[i].Equals(n[n.Length-1- i]))
                {
                    palindrom = false;
                    break;
                }
            }

            if (palindrom)
            Console.WriteLine("Wyrażenie JEST palindromem!");
            else Console.WriteLine("Wyrażenie NIE JEST palindromem!");

            Console.ReadKey();
        }


        public static void OpcjawBudowie()
        {
            Console.WriteLine("Wkrótce będzie tu ciekawy program");
            Console.ReadKey();
        }


    }
}
