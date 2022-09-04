// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутк

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int FindSum(int m, int n)
{
    return m > n ? 0 : FindSum(m + 1, n) + m;
}

int sum = FindSum(Prompt("Введите число M > "), Prompt("Введите число N > "));
System.Console.WriteLine($"Cумма элементов в промежутке от M до N -> {sum}");