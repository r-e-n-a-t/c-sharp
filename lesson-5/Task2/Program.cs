// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int len, int min, int max)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void showArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}

int SumNegativeIndexNums(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += array[i];
        }
    };
    return result;
}

int[] array = CreateArray(4, -10, 10);
showArray(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях => {SumNegativeIndexNums(array)}");
