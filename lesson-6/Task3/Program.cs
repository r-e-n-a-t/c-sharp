// Задача 3. Со Звездочкой (*). Сгенерировать двумерный массив со случайными числами, вывести его на экран, оформить в виде функций (пригодится в дальнейшем)

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
            System.Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

int[,] array = CreateTwoDimArray(2, 10, 10, 100);
showTwoDimArray(array);