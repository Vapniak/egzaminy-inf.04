namespace konsolowa;

class Program
{
    static void Main(string[] args)
    {
        var film = new Film();

        Console.WriteLine($"Tytuł filmu: {film.GetTytul()}, Liczba wypożyczeń: {film.GetLiczbaWypozyczen()}");

        film.SetTytul("Atak Tytanów");

        Console.WriteLine($"Ustawiony tytuł: {film.GetTytul()}");

        Console.WriteLine($"Liczba wypożyczeń: {film.GetLiczbaWypozyczen()}");
        film.Wypozycz();
        Console.WriteLine($"Liczba wypożyczeń po wypożyczeniu: {film.GetLiczbaWypozyczen()}");
    }
}

/******************************************************
nazwa klasy: Film
pola:   tytul - nazwa filmu
        liczbaWypozyczen - liczba wypozyczen
metody: SetTytul , void – ustawia tytuł filmu na ten przekazany w parametrze
        GetTytul, tytuł filmu – zwraca tytuł filmu
        GetLiczbaWypozyczen, liczba wypozyczen filmu – liczba wypozyczen filmu
        Wypozycz, void – zwiększa lcizbę wypożyczeń o jeden
informacje: obiekt filmu przechowywujący jego nazwę i liczbę wypożyczeń
autor: <numer zdającego>
*****************************************************/
class Film
{
    protected string tytul = "";
    protected int liczbaWypozyczen = 0;

    public void SetTytul(string tytul)
    {
        this.tytul = tytul;
    }

    public string GetTytul()
    {
        return tytul;
    }

    public int GetLiczbaWypozyczen()
    {
        return liczbaWypozyczen;
    }

    public void Wypozycz()
    {
        liczbaWypozyczen++;
    }
}
