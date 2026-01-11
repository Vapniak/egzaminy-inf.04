public class Program
{
    public static void Main(string[] args)
    {
        var pralka = new Pralka();
        var odkurzacz = new Odkurzacz();

        Console.WriteLine("Podaj numer prania 1..12");
        int numerPrania = int.Parse(Console.ReadLine());

        var program = pralka.UstawProgram(numerPrania);
        if(program == 0)
        {
            Console.WriteLine("Podano niepoprawny numer programu");
        }
        else
        {
            Console.WriteLine("Program został ustawiony");
        }

        odkurzacz.On();
        odkurzacz.On();
        odkurzacz.On();
        odkurzacz.WyswietlKomunikat("Odkurzacz wyładował się");
        odkurzacz.Off();
    }
}


public class Urzadzenie
{
    /*
    ************************************************
    nazwa: <tu wstaw nazwę metody>
    opis: <co wykonuje metoda?>
    parametry:  <nazwa i opis parametru1, lub „brak”>
                <nazwa i opis parametru2>
                ...
    zwracany typ i opis: <nazwa typu i opis co jest zwracane lub „brak”>
    autor: <numer zdającego>
    ************************************************
    */

     /*
    ************************************************
    nazwa: WyswietlKomunikat
    opis: Wyswietla komunikat w konsoli
    parametry:  komunikat - wiadomość którą wyświetli w konsoli
    zwracany typ i opis: brak
    autor: <numer zdającego>
    ************************************************
    */
    public void WyswietlKomunikat(string komunikat)
    {
        Console.WriteLine(komunikat);
    }
}

public class Pralka : Urzadzenie
{
    private int numerProgramu = 0;

     /*
    ************************************************
    nazwa: Ustaw program
    opis: Ustawia podany program jeśli jest pomiędzy 1 a 12
    parametry:  numerProgramu - numer programu do ustawienia
    zwracany typ i opis: int - ustawiony program, jeśli nie jest między 1 a 12 to zwraca 0
    autor: <numer zdającego>
    ************************************************
    */
    public int UstawProgram(int numerProgramu)
    {
        if(numerProgramu >= 1 && numerProgramu <= 12)
        {
            this.numerProgramu = numerProgramu;
            return this.numerProgramu;
        }

        this.numerProgramu = 0;
        return 0;
    }
}

public class Odkurzacz : Urzadzenie
{
    private bool wlaczony = false;

     /*
    ************************************************
    nazwa: On
    opis: Włącza odkurzacz i wyświetla komunikat o włączeniu
    parametry:  brak
    zwracany typ i opis: brak
    autor: <numer zdającego>
    ************************************************
    */
    public void On()
    {
        if(wlaczony)
        {
            return;
        }

        wlaczony = true;
        WyswietlKomunikat("Odkurzacz włączono");
    }
    
     /*
    ************************************************
    nazwa: Off
    opis: Wyłącza odkurzacz i wyświetla komunikat o wyłączeniu
    parametry:  brak
    zwracany typ i opis: brak
    autor: <numer zdającego>
    ************************************************
    */
    public void Off()
    {
        if (!wlaczony)
        {
            return;
        }

        wlaczony = false;
        WyswietlKomunikat("Odkurzacz wyłączono");
    }
}
