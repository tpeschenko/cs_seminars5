//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void Task34()
{
    int size = 4;

    int[] numbers = new int[size];

    FillArray(numbers);
    PrintArray(numbers);
    PrintEvenNumbers(numbers);
    
    void FillArray(int[] num)   
    {
        Random rand = new Random();
        int LonArray = num.Length;
        for(int i = 0; i < LonArray; i++)
        {
            num[i] = rand.Next(100, 1000);
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

    void PrintEvenNumbers(int[] num)
    {
        Console.WriteLine("Чётные числа в массиве: ");
        int LonArray = num.Length;
        for(int i = 0; i < LonArray; i++)
        {
            if (num[i] % 2 == 0 )
            {
                Console.Write(num[i] + " ");
            }
 
        }
        Console.WriteLine();
    }
}

Task34();

