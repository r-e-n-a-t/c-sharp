// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

void FindPositiveNums(int m, int n)
{
    if (m <= n) 
    {
        if (m % 2 == 0) System.Console.Write($"{m} ");
        FindPositiveNums(m + 1, n);
    }

}

int m = Prompt("Введите первое число > ");
int n = Prompt("Введите второе число > ");
FindPositiveNums(m, n);

