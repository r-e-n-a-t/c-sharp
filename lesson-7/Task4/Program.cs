// Задача 4. Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их. Затем найдите минимальное значение по каждой колонке, тоже ссумируйте их. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

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

void showTwoDimArray(int[,] array)
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

int SumLineMax(int[,] array) 
{
    int max = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        max = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] > max)
            {
                max = array[i, j];
            }
        }
        result += max;
    }
    return result;
}

int SumColumnMin(int[,] array) 
{
    int min = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        min = array[0, i];
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if(array[j, i] < min)
            {
                min = array[j, i];
            }
        }
        result += min;
    }
    return result;
}

int[,] array = CreateTwoDimArray(Prompt("Введите количество строк > "), Prompt("Введите количество столбцов > "), 1, 10);
showTwoDimArray(array);
System.Console.WriteLine($"Разность сумм максимальных элементов каждой строки и минимальных элементов каждого столбца =");
System.Console.WriteLine(SumLineMax(array) - SumColumnMin(array));