// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
string Prompt(string message)
{
    System.Console.Write(message);
    string result = Console.ReadLine();
    return result;
}
string NumberRev(string value)
{
    int num = int.Parse(value);
    string result = "";
    int a = 0;
    for (int i = 0; i < value.Length; i++)
    {
        a = num % 10;
        num = num / 10;
        result += a;
    };
    return result;
}
string NumberСheck(string value1, string value2)
{
    string result = $"Число {value1} не является палиндромом";
    if (value1 == value2)
    {
        result = $"Число {value1} является палиндромом";
    }
    return result;
}

string numberOne = Prompt("Введите число >");
string numberTwo = NumberRev(numberOne);
string message = NumberСheck (numberOne, numberTwo);
System.Console.Write(message);