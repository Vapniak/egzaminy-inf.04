internal class Program
{
    public static void Main(string[] args)
    {
        var notatka1 = new Notatka("Zakupy", "Jajka, Chleb, Mleko");
        var notatka2 = new Notatka("Zadania domowe", 
        "-1 strona 100\n-3 strona 99"); 

        notatka1.WypiszTrescITytul();
        notatka1.WypiszWszystko();

        notatka2.WypiszTrescITytul();
        notatka2.WypiszWszystko();  
    }
}


/************************************************
klasa:  Notatka
opis:   Reprezentuję notatkę jako obiekt
pola:   liczbaNotatek - liczba wszystkich notatek, które zostały utworzone
        id - unikalne id notatki
        tytul - tytuł notatki podany przy tworzeniu obiektu
        tresc - treść notatki podana przy tworzeniu obiektu
autor: <numer zdającego>
************************************************/
class Notatka
{
    private static int liczbaNotatek;
    private int id;
    protected string tytul;
    protected  string tresc;


    public Notatka(string tytul, string tresc)
    {
        liczbaNotatek++;
        id = liczbaNotatek;
        this.tytul = tytul;
        this.tresc = tresc;
    }

    public void WypiszTrescITytul()
    {
        Console.WriteLine(
            $"Tytuł: \n{tytul}\nTreść: \n{tresc}");
    }

    public void WypiszWszystko()
    {
        Console.WriteLine($"Liczba notatek: {liczbaNotatek};Id: {id};Tytuł: {tytul};Treść: {tresc}");
    }
}