// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Task36()

{
    int size = 4;
    double[] numbers = new double[size];

    FillArray(numbers);
    PrintArray(numbers);
    PrintMaxNumber(numbers);
    PrintMinNumber(numbers);
    PrintDifferenceMaxMin(PrintMaxNumber(numbers), PrintMinNumber(numbers));
    
    
    void FillArray(double[] num)   
    {
        Random rand = new Random();
        int LonArray = num.Length;
        for(int i = 0; i < LonArray; i++)
        {
            num[i] = rand.NextDouble() * 10;
        }   
    }
    // Для проверки массива!
    void PrintArray(double[] num)
    {
        int LonArray = num.Length;
        Console.WriteLine("Вводный массив: ");
        for(int i = 0; i < LonArray; i++)
        {
            Console.Write(num[i] + " ");
        }
        Console.WriteLine();
    }

    double PrintMaxNumber(double[] num)
    {
        int LonArray = num.Length;
        double max = 0;
        for(int i = 0; i < LonArray; i++)
        {
            if(num[i] > max)
            {
                max = num[i];
            } 
        }
        Console.WriteLine($"Максимальный элемент: {max}");
        return max;
    }

    double PrintMinNumber(double[] num)
    {
        int LonArray = num.Length;
        double min = num[0];
        for(int i = 0; i < LonArray; i++)
        {
            if(num[i] < min)
            {
                min = num[i];
            } 
        }
        Console.WriteLine($"Минимальный элемент: {min}");
        return min;
    }

    void PrintDifferenceMaxMin (double max, double min)
    {
        double DifferenceNumbers = 0;
        DifferenceNumbers = max - min;
        Console.WriteLine($"Разница между элементами: {DifferenceNumbers}");
    }

}

Task36();