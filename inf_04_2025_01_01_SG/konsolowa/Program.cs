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
        nazwa metody: <nazwa>
        opis metody: <krótki opis, co robi metoda>
        parametry:  <nazwa i opis parametru1, lub „brak”>
                    <nazwa i opis parametru2>

        zwracany typ i opis: <nazwa typu i opis co jest zwracane lub „brak”>
        autor: <numer zdającego>
        ***********************************************
        */
  
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