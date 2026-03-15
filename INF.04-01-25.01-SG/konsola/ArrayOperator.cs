public class ArrayOperator
{
    private int[] array;
    private int length;

    public ArrayOperator(int length)
    {
        this.length = length;
        array = new int[length];
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(1, 1001);
        }
    }
    public void PrintArray()
    {
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(i + ": " + array[i]);
        }
    }

    public int FindValue(int x)
    {
        int idx = -1;
        for (int i = 0; i < length; i++)
        {
            if (array[i] == x)
            {
                idx = i;
                break;
            }
        }
        return idx;
    }

    public void PrintOdds()
    {
        int sum = 0;
        Console.WriteLine("Liczby nieparzyste: ");
        for (int i = 0; i < length; i++)
        {
            if (array[i] % 2 != 0)
            {
                Console.WriteLine(array[i]);
                sum++;
            }
        }
        Console.WriteLine("Razem nieparzystych " + sum);
    }

    public double CalculateAverage()
    {
        int sum = 0;
        for (int i = 0; i < length; i++)
        {
            sum += array[i];
        }
        return sum / length;
    }
}