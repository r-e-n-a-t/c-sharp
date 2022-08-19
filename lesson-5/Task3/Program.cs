// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int len, int min, int max)
{
    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max) / 10.0;
    }
    return array;
}

void showArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}

double FindMinNum(double[] array)
{
    double result = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (result > array[i])
        {
            result = array[i];
        }
    };
    return result;
}

double FindMaxNum(double[] array)
{
    double result = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (result < array[i])
        {
            result = array[i];
        }
    };
    return result;
}

double CompareNum(double[] array)
{
    double max = FindMaxNum(array);
    double min = FindMinNum(array);
    double result = max - min;
    return result;
}

double[] array = CreateArray(5, -100, 100);
showArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом => {CompareNum(array)}");

