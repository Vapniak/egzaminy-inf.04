public class Program
{
    public static void Main(string[] args)
    {
        var tablica = new Tablica(49);

        tablica.WypiszElementy();

        var index = tablica.Szukaj(139);

        if(index != -1)
        {
            Console.WriteLine("Znaleziono liczbę 139 pod indexem " + index);
        }

        Console.WriteLine("Liczby nieparzyste: ");
        var liczba = tablica.WypiszNieparzysteIPolicz();
        Console.WriteLine("Razem nieparzystych: " + liczba);

        Console.WriteLine("Średnia wszystkich elementów: " + tablica.PoliczSrednia());
    }

    public class Tablica
    {
        private int[] tab;
        private int rozmiar;

        public Tablica(int rozmiar)
        {
            this.rozmiar = rozmiar;

            var rand = new Random();

            tab = new int[rozmiar];

            for(var i = 0; i < rozmiar; i++)
            {
                tab[i] = rand.Next(1, 1001);
            }  
        }
  
         /*
        **********************************************
        nazwa metody: WypiszElementy
        opis metody: Wypisuje każdy element z tablicy
        parametry:  brak

        zwracany brak
        autor: <numer zdającego>
        ***********************************************
        */
        public void WypiszElementy()
        {
            for(var i = 0; i < rozmiar; i++)
            {
                Console.WriteLine($"{i}: {tab[i]}");
            }
        }

        /*
        **********************************************
        nazwa metody: Szukaj
        opis metody: Szuka daną wartość i zwraca indeks pod którym jest pierwsze jej wystąpienie
        parametry:  wartosc - wartość która jest szukana w tablicy

        zwracany typ i opis: int - indeks znalezionego elementu, -1 gdy go nie znaleziono
        autor: <numer zdającego>
        ***********************************************
        */
        public int Szukaj(int wartosc)
        {
            for(var i = 0; i < rozmiar; i++)
            {
                if(tab[i] == wartosc)
                {
                    return i;
                }
            }

            return -1;
        }

          /*
        **********************************************
        nazwa metody: WypiszNieparzysteIPolicz
        opis metody: Wypisuje do konsoli wszystkie liczby nieparzyste w tablicy i zlicza ile ich wszystkich razem jest
        parametry:  brak

        zwracany typ i opis: int - liczba nieparzystych liczb
        autor: <numer zdającego>
        ***********************************************
        */
        public int WypiszNieparzysteIPolicz()
        {
            var liczbaNieparzystych = 0;
            for(var i = 0; i < rozmiar; i++)
            {
                if(tab[i] % 2 == 0)
                {
                    liczbaNieparzystych++;
                    Console.WriteLine(tab[i]);
                }
            }

            return liczbaNieparzystych;
        }

        /*
        **********************************************
        nazwa metody: PoliczSrednia
        opis metody: liczy średnią wszystkich elementów tablicy
        parametry:  brak

        zwracany typ i opis: float - średnia wszystkich liczb tablicy
        autor: <numer zdającego>
        ***********************************************
        */
        public float PoliczSrednia()
        {
            var srednia = 0.0f;
            foreach(var elem in tab)
            {
                srednia += elem;
            }

            srednia /= rozmiar;

            return srednia;
        }
    }
}