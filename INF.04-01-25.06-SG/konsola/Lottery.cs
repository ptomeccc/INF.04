public class Lottery
{
    int[,] arr;
    
    public Lottery(int n)
    {
        arr = new int[n, 6];
    }

    private bool ValueExists(int row, int value)
    {
        for (int j = 0; j < 6; j++)
        {
            if (arr[row, j] == value)
                return true;
        }
        return false;
    }
    
    public void Draw()
    {
        // Instacja klasy Random, służąca do generowania liczb pseudolosowych
        Random rand = new Random();
        
        // Wypełnienie tablicy wartościami
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int val;
                do
                {
                    val = rand.Next(1, 50);
                } while (ValueExists(i, val));
                arr[i, j] = val;
            }   
        }
    }

    public void Display()
    {
        // Wyświetlenie tablicy
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("Losowanie: " + (i+1) +  ": ");
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }   
            Console.WriteLine();
        }
    }

    public void Count()
    {
        int count = 0;
        for (int i = 1; i < 50; i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    if (arr[j, k] == i)
                    {
                        count++;
                    }
                }   
            }
            Console.Write("Wystąpienie liczby " + i + ": " + count + "\n");
            count = 0;
        }
    }
}