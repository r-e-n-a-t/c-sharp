// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

string Prompt(string message)
{
    System.Console.Write(message);
    string result = Console.ReadLine();
    if (result.Length != 3)
    {
        result = "error";
    }
    return result;
}

int pullNumber(string value)
{
    int result = int.Parse(value) / 10 % 10;
    return result;
}

string message = Prompt("Введите трёхзначное число >");
if (message == "error")
{
    System.Console.Write(message);
}
else
{
    int number = pullNumber(message);
    System.Console.Write(number);
}


