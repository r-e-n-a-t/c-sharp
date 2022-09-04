// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int sum = 0;

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

void FindSum(int m, int n)
{
    if (m <= n) 
    {
        sum += m;
        FindSum(m + 1, n);
    }
}

FindSum(Prompt("Введите число M > "), Prompt("Введите число N > "));
System.Console.WriteLine($"Cумма элементов в промежутке от M до N -> {sum}");