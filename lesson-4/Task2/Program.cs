// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int Sum(int number)
{   
    int result = 0;
    while (number > 0)
    {
        int a = number % 10;
        result += a;
        number = number / 10;
    };
    return result;
}

int number = Prompt("Введите число >");
int sumNumber = Sum(number);
System.Console.Write(sumNumber);


