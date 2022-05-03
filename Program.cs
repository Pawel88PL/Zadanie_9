using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program sprawdza, czy podana liczba jest liczbą pierwszą nie wykorzystując
            // operacji dzielenia. Wykorzystano sito Eratostenesa i tablicę elementów typu bool.
            // Dodatkowo program obsługuje wyjątki.

            int i, j, zakres, dokad;
            int[] tablica = new int[10000];
            string koniec;

            Console.WriteLine("Program wyświetla zbiór liczb pierwszych z podanego zakresu. Dostępny zakres 1 - 9999");
            Console.WriteLine();

            do
            {
                Console.Write("Podaj górny zakres, do którego chcesz odnaleźć liczby pierwsze: ");
                if (int.TryParse(Console.ReadLine(), out zakres) && zakres > 1)
                {
                    
                    dokad =(int) Math.Floor(Math.Sqrt(zakres));

                    for (i = 1; i <= zakres; i++)
                    {
                        tablica[i] = i;
                    }

                    for (i = 2; i <= dokad; i++)
                    {
                        if (tablica[i] != 0)
                        {
                            j = i + i;
                            while (j <= zakres)
                            {
                                tablica[j] = 0;
                                j += i;
                            }
                        }
                    }

                    Console.WriteLine("Liczby pierwsze z zakresu od 1 do " + zakres + " to:");
                    for (i = 2; i <= zakres; i++)
                    {
                        if (tablica[i] !=0)
                        {
                            Console.Write(i + ", ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Czy chcesz zamknąć program? Tak - Enter, Nie - wpisz słowo 'nie'.");
                    koniec = Console.ReadLine();
                }
                else if (zakres > 0 && zakres < 2)
                {
                    Console.WriteLine("Liczba 1 nie jest liczbą pierwszą!");
                    koniec = "nie";
                    
                }
                else 
                {
                    Console.WriteLine("Błędna wartość. Spróbuj ponownie!");
                    koniec = "nie";
                }

                
            }
            while (koniec == "nie");
        }
    }
}
