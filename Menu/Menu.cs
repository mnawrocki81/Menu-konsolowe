using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        static string[] pozycjaMenu = {
        "1. Wskaźnik BMI",
        "2. Prosty kalkulator",
        "3. Liczby doskonałe",
        "4. Przeliczanie temperatur",
        "5. Palindromy",
        "6. Liczby Fibonacciego",
        "7. Symbol Newtona",
        "8. Liczby pierwsze",
        "9. Jaki mamy miesiąc?",
        "Wyjście", };
        static int aktywnaPozycjaMenu = 0;

        public static void StartMenu1()
        {
            Console.Title = "Menu";
            Console.CursorVisible = false;
            while (true)
            {
                PokazMenu();
                WybierzOpcje();
                UruchomOpcje();
            }
        }

        static void PokazMenu()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(">>> MENU PRZYKŁADOWYCH PROGRAMÓW <<< ");
            Console.WriteLine();
            for (int i = 0; i < pozycjaMenu.Length; i++)
            {
                if (i == aktywnaPozycjaMenu)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0,-35}", pozycjaMenu[i]);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.WriteLine(pozycjaMenu[i]);
                }
            }
        }

        static void WybierzOpcje()
        {

            do
            {
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.UpArrow)
                {
                    aktywnaPozycjaMenu = (aktywnaPozycjaMenu > 0) ? aktywnaPozycjaMenu - 1 : pozycjaMenu.Length - 1;
                    PokazMenu();
                }

                else if (klawisz.Key == ConsoleKey.DownArrow)
                {
                    aktywnaPozycjaMenu = (aktywnaPozycjaMenu + 1) % pozycjaMenu.Length;
                    PokazMenu();
                }
                else if (klawisz.Key == ConsoleKey.Escape)
                {
                    aktywnaPozycjaMenu = pozycjaMenu.Length - 1;
                    break;

                }
                else if (klawisz.Key == ConsoleKey.Enter)
                    break;
            } while (true);
        }

        static void UruchomOpcje()
        {
            switch (aktywnaPozycjaMenu)
            {
                case 0:
                    Console.Clear();
                    Programy.BMI();
                    break;
                case 1:
                    Console.Clear();
                    Programy.Kalkulator();
                    break;
                case 2:
                    Console.Clear();
                    Programy.LiczbyDoskonale();
                    break;
                case 3:
                    Console.Clear();
                    Programy.PrzeliczanieTemperatur();
                    break;
                case 4:
                    Console.Clear();
                    Programy.Palindrom();
                    break;
                case 5:
                    Console.Clear();
                    Programy.LiczbyFibonacciego();
                    break;
                case 6:
                    Console.Clear();
                    Properties.SymbolNewtona.Obliczenie();
                    break;
                case 7:
                    Console.Clear();
                    Properties.LiczbyPierwsze.Obliczenie();
                    break;
                case 8:
                    Console.Clear();
                    Programy.JakiMiesiąc();
                    break;
                case 9:
                     Environment.Exit(0); break;
            }
        }

        // Menu, druga wersja
        public static void StartMenu2()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Menu";

            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>>>MENU PRZYKŁADOWYCH PROGRAMÓW<<<");
                Console.WriteLine("1 - Wskaźnik BMI");
                Console.WriteLine("2 - Prosty kalkulator");
                Console.WriteLine("3 - Liczby doskonałe");
                Console.WriteLine("4 - Przeliczanie temperatur");
                Console.WriteLine("5 - Palindromy");
                Console.WriteLine("6 - Liczby Fibonacciego");
                Console.WriteLine("7 - Symbol Newtona");
                Console.WriteLine("8 - Liczby pierwsze");
                Console.WriteLine("9 - Jaki mamy miesiąc?");
                Console.WriteLine("0 - Koniec");

                ConsoleKeyInfo klawisz = Console.ReadKey();

                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Programy.BMI(); break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear(); Programy.Kalkulator(); break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear(); Programy.LiczbyDoskonale(); break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear(); Programy.PrzeliczanieTemperatur(); break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear(); Programy.Palindrom(); break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Console.Clear(); Programy.LiczbyFibonacciego(); break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        Console.Clear(); Properties.SymbolNewtona.Obliczenie(); break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        Console.Clear(); Properties.LiczbyPierwsze.Obliczenie(); break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        Console.Clear(); Programy.JakiMiesiąc(); break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        Environment.Exit(0); break;
                    default: break;
                }
            }
        }
    }
}
