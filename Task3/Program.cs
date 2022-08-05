// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

string ParityCheck(int num)
{
    string result;
    if ((num % 2) == 0)
    {
        result = $"Число {num} чётное";
    }
    else
    {
        result = $"Число {num} нечётное";
    }
    return result;
}

int num = Prompt("Введите число >");

System.Console.WriteLine(ParityCheck(num));