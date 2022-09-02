// Задача 4. Со звездочкой (*) Напишите программу, которая заполнит спирально квадратный массив.


int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int[,] CreateSquareArray(int num)
{
    int[,] array = new int[num, num];
    int amount = num * num;
    int line = 1;
    int coll = 1;
    int count = 1;

    for (int i = 0; i < num; i++)
    {
        array[0, i] = count;
        count++;
    }
    for (int i = 1; i < num; i++)
    {
        array[i, num - 1] = count;
        count++;
    }
    for (int i = num - 2; i >= 0; i--)
    {
        array[num - 1, i] = count;
        count++;
    }
    for (int i = num - 2; i > 0; i--)
    {
        array[i, 0] = count;
        count++;
        if (count == amount)
        {
            array[line, coll] = count;
        }
    }

    while (count < amount)
    {
        while (array[line, coll + 1] == 0)
        {
            array[line, coll] = count;
            count++;
            coll++;
        }

        while (array[line + 1, coll] == 0)
        {
            array[line, coll] = count;
            count++;
            line++;
        }

        while (array[line, coll - 1] == 0)
        {
            array[line, coll] = count;
            count++;
            coll--;
        }

        while (array[line - 1, coll] == 0)
        {
            array[line, coll] = count;
            count++;
            line--;
        }
        if (count == amount)
        {
            array[line, coll] = count;
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

int num = Prompt("Введите количество строк и столбцов -> ");
int[,] array = CreateSquareArray(num);
ShowTwoDimArray(array);