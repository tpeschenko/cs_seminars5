//  Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число. Напишите программу,
// которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.
// {0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
// {4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет


void Task101()
{
    int size = 15;
    int[] numbers = new int[size];
    int lonArray = numbers.Length;
    string str = String.Empty;
    string finalStr = String.Empty;

    Console.WriteLine("Введите трехpначное натуральное число: ");
    string number = Console.ReadLine();

    FillArray(numbers);
    PrintArray(numbers);
    FindElementsNumberInArray(numbers, number);

    void FillArray(int[] num)   
    {
        Random rand = new Random();
        for(int i = 0; i < lonArray; i++)
        {
            num[i] = rand.Next(1, 10);
        }
    }
    void PrintArray(int[] num)
    {
        for(int i = 0; i < lonArray; i++)
        {
            Console.Write(num[i] + " ");
        }
        Console.WriteLine();        
    }   
    void FindElementsNumberInArray(int[] num, string numb)
    {
        for(int i = 0; i < lonArray; i++)
        {
            str = num[i].ToString();
            finalStr += str;             
        }    
       
    } 
}

Task101();