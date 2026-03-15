public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ile wygenerować losowań?");
        int n = int.Parse(Console.ReadLine() ?? "0");
        Lottery lottery = new Lottery(n);
        lottery.Draw();
        lottery.Display();
        lottery.Count();
    }
}