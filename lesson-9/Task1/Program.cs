// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void FindPositiveNums(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0) System.Console.Write($"{m} ");
    FindPositiveNums(m + 1, n);
}

FindPositiveNums(Prompt("Введите первое число > "), Prompt("Введите второе число > "));