public class Program
{
    public static void Main(string[] args)
    {
        int numberOfDices;
        do
        {   
            Console.WriteLine("Ile kostek chcesz wyrzucić?(3 - 10)");
            numberOfDices = int.Parse(Console.ReadLine());
            
        }while(numberOfDices < 3 || numberOfDices > 10);

        while (true)
        {
            var diceThrows = new int[numberOfDices];

            for(var i = 0; i < numberOfDices; i++)
            {
                diceThrows[i] = ThrowDice();
                Console.WriteLine($"Kostka {i + 1}: {diceThrows[i]}");
            }

            Console.WriteLine($"Liczba uzyskanych punktów: {CountPoints(diceThrows)}");

            Console.WriteLine("Jeszcze raz? (t/n)");
            char answer = Console.ReadLine()[0];

            if(answer == 't')
            {
                continue;
            }
            else
            {
                return;
            }
        }
    }


    /*
    ************************************************
    nazwa: ThrowDice
    opis: Rzuca kością i zwraca wynik wylosowanego wyniku rzutu
    parametry:  brak
                ...
    zwracany typ i opis: int - wylosowany wynik rzutu kości
    autor: <numer zdającego>
    ************************************************
    */
    public static int ThrowDice()
    {
        return Random.Shared.Next(1, 7);;
    }

    /*
    ************************************************
    nazwa: CountPoints
    opis: liczy punkty z rzutów koścmi. Punkty są sumą oczek, gdy dana liczba została wylosowana dwa razy lub więcej.
    parametry:  diceThrows - tablica z liczbą oczek które zostały wylosowane dla liczby kości
    zwracany typ i opis: int - suma pukntów wszystkich oczek gdy dana liczba została wylosowana dwa razy lub więcej
    autor: <numer zdającego>
    ************************************************
    */
    public static int CountPoints(int[] diceThrows)
    {
        var numberOfOccurences = new int[7];

        foreach(var diceThrow in diceThrows)
        {
            numberOfOccurences[diceThrow]++;
        }

        var points = 0;
        for(var i = 0; i < numberOfOccurences.Length; i++)
        {
            if(numberOfOccurences[i] > 1)
            {   
                points += numberOfOccurences[i] * i;
            }
        }

        return points;
    }
}