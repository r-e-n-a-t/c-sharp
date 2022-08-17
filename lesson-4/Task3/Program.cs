// Задача 3: Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

void randomArray (int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(1, 100);
    }
}

void showArray (int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        System.Console.Write($"{array[i]}  ");
    }
}

int FindSecondMax(int[] array)
{   
    int firstMax = 0;
    int secondMax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > firstMax)
        {
            firstMax = array[i];
        }
    };
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > secondMax && array[j] < firstMax)
        {
            secondMax = array[j];
        }
    };
    return secondMax;
}

int[] array = new int[8];
randomArray(array);
showArray(array);
System.Console.WriteLine("");
System.Console.WriteLine($"Второе максимальное число => {FindSecondMax(array)}");


