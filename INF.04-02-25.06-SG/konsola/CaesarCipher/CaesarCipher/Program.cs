class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj tekst do zaszyfrowania: ");
        string text = Console.ReadLine() ?? "";
        Console.WriteLine("Podaj klucz szyfrowania: ");
        int key = int.Parse(Console.ReadLine() ?? "0");
        CaesarCipher cipher = new CaesarCipher(text, key);
        Console.WriteLine("Zaszyfrowany tekst: " + cipher.encrypt());
    }
}