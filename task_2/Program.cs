// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

void Task36()
{
    int size = 10;

    int[] numbers = new int[size];

    FillArray(numbers);
    PrintArray(numbers);
    PrintSumOddNumbers(numbers);
    
    void FillArray(int[] num)   
    {
        Random rand = new Random();
        int LonArray = num.Length;
        for(int i = 0; i < LonArray; i++)
        {
            num[i] = rand.Next(1, 100);
        }   
    }

    void PrintArray(int[] num)
    {
        int LonArray = num.Length;
        Console.WriteLine("Вводный массив: ");
        for(int i = 0; i < LonArray; i++)
        {
            Console.Write(num[i] + " ");
        }
        Console.WriteLine();
    }   

    void PrintSumOddNumbers(int[] num)
    {
        int LonArray = num.Length;
        int sum = 0;
        for(int i = 0; i < LonArray; i++)
        {
            if (num[i] % 2 != 0 )
            {
                sum = sum + num[i];
            }

        }
        Console.WriteLine();
        Console.WriteLine($"Сумма нечетных чисел: {sum}");   
    }
}

Task36();
