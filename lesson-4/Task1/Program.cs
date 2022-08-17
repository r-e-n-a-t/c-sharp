// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

double PowerNumber(int a, int b)
{   
    double result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

int a = Prompt("Введите первое число >");
int b = Prompt("Введите второе число >");
double number = PowerNumber(a, b);

System.Console.Write(number);


