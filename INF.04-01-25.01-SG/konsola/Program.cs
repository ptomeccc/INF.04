class Program
{
    static void Main(string[] args)
    {
        ArrayOperator arrayOperator = new ArrayOperator(21);
        arrayOperator.PrintArray();
        if (arrayOperator.FindValue(57) != -1)
        {
            Console.Write(arrayOperator.FindValue(57)+"\n");
        }
        arrayOperator.PrintOdds();
        Console.Write("Średnia wszystkich elementów: " + arrayOperator.CalculateAverage());
    }
}
