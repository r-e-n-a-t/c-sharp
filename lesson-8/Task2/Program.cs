// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int[,] CreateTwoDimArray(int lines, int columns, int min, int max)
{
    int[,] array = new int[lines, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void ShowTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int SearchSmallestLine(int[,] array) 
{
    int line = 0;
    int result = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        System.Console.WriteLine($"Сумма чисел в строке {i + 1} = {sum}");
        if (sum <= result || result == 0)
        {
            result = sum;
            sum = 0;
            line = i + 1;
        }
    }
    return line;
}

int[,] array = CreateTwoDimArray(3, 3, 1, 10);
ShowTwoDimArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Строка с наименьшей суммой элементов -> {SearchSmallestLine(array)}");