namespace konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile wygenerować losowań?");
            var n = int.Parse(Console.ReadLine());

            var losowania = new int[n][];

            for (var i = 0; i < n; i++)
            {
                losowania[i] = new int[6];
                WypelnijLosowaniami(losowania[i]);
            }

            WyswietlLosowania(losowania);
            WyswietlWystapienia(losowania);
        }


        /**********************************************
        nazwa funkcji: WypelnijLosowaniami
        opis funkcji: Wypełnia tablicę pseudolosowymi liczbami w zakresie 1-49 bez powtórzeń.
        parametry: tab - tablica którą wypełni losowaniami, musi być wcześniej zainicjowana zerami aby została wypełniona
        zwracany typ i opis: brak
        autor: <numer zdającego>
        ***********************************************/
        public static void WypelnijLosowaniami(int[] tab)
        {
            var rand = new Random();

            for(var i = 0; i < tab.Length; i++)
            {
                var liczba = 0;
                do
                {
                    liczba = rand.Next(1, 50);
                } while (tab.Contains(liczba));
                tab[i] = liczba;
            }
        }



        /**********************************************
        nazwa funkcji: WyswietlLosowania
        opis funkcji: Wyświetla wszystkie losowania
        parametry: tab - tablica z tablicami wszystkich elementów losowań
        zwracany typ i opis: brak
        autor: <numer zdającego>
        ***********************************************/
        public static void WyswietlLosowania(int[][] tab)
        {

            Console.WriteLine("Zestawy wylosowanych liczb:");
            for (var i = 0; i < tab.Length; i++)
            {
                Console.Write($"Losowanie {i + 1}: ");
                foreach (var liczba in tab[i])
                {
                    Console.Write($"{liczba} ");
                }

                Console.WriteLine();
            }
        }


        /**********************************************
        nazwa funkcji: WyswietlWystapienia
        opis funkcji: Zlicza wystąpienia każdej z liczb od 1 do 49 i je wyświetla
        parametry: tab - tablica z tablicami wszystkich elementów 
        zwracany typ i opis: brak
        autor: <numer zdającego>
        ***********************************************/
        public static void WyswietlWystapienia(int[][] tab)
        {
            var wystapienia = new int[50];
            for(var i = 0; i < tab.Length; i++)
            {
                for(var j = 0; j < tab[i].Length; j++)
                {
                    wystapienia[tab[i][j]]++;
                }
            }

            for(var i = 1; i < wystapienia.Length; i++)
            {
                Console.WriteLine($"Wystąpienia liczby {i}: {wystapienia[i]}");
            }
        }
    }
}
