class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.liczbaOsob}");

        var osoba1 = new Osoba();

        Console.WriteLine("Podaj id osoby:");
        var id = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj imię osoby:");
        var imie = Console.ReadLine();
        var osoba2 = new Osoba(id, imie);

        var osoba3 = new Osoba(osoba2);

        osoba1.Przywitaj("Jan");
        osoba2.Przywitaj("Jan");
        osoba3.Przywitaj("Jan");


        Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.liczbaOsob}");
    }
}

class Osoba
{
    private int id;
    private string imie;
    public static int liczbaOsob = 0;

    public Osoba()
    {
        id = 0;
        imie = "";
        liczbaOsob++;
    }

    public Osoba(int id, string imie)
    {
        this.id = id;
        this.imie = imie;

        liczbaOsob++;
    }

    public Osoba(Osoba osoba)
    {
        id = osoba.id;
        imie = osoba.imie;

        liczbaOsob++;
    }

    public void Przywitaj(string osoba)
    {
        if(imie == "")
        {
            Console.WriteLine("Brak danych");
            return;
        }

        Console.WriteLine($"Cześć {osoba}, mam na imię {imie}");
    }
}