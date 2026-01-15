namespace konsolowa
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst do zaszyfrowania:");
            var text = Console.ReadLine();

            Console.WriteLine("Podaj klucz szyfrowania: ");
            var key = int.Parse(Console.ReadLine());

            Console.WriteLine("Zaszyfrowany tekst to: " + Encrypt(text, key));
        }

        public static string Encrypt(string text, int key)
        {
            if(key == 0)
            {
                return text;
            }

            var encryptedText = "";
            var displace = key % 26;

            for(var i = 0; i < text.Length; i++)
            {
                var c = text[i];
                
                if(c != ' ')
                {
                    c +=  (char)displace;
                    if(c < 97)
                    {
                        c += (char)26;
                    }
                    else if(c > 122)
                    {
                        c -= (char)26;  
                    }
                }

                encryptedText += c;
            }

            return encryptedText;
        }
    }
}
