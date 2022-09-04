// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутк

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int FindSum(int m, int n)
{
    int sum = 0;
    if (m > n) return sum;
    sum += m;
    return FindSum(m + 1, n) + sum;
}

int sum = FindSum(Prompt("Введите число M > "), Prompt("Введите число N > "));
System.Console.WriteLine($"Cумма элементов в промежутке от M до N -> {sum}");