// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}
int CompareNumbers(int firstNum, int secondNum, int thirdNum)
{
    int result = firstNum;
    if (result <= secondNum)
    {
        result = secondNum;
    }
    if (result <= thirdNum)
    {
        result = thirdNum;
    }
    return result;
}

int firstNum = Prompt("Введите первое число >");
int secondNum = Prompt("Введите второе число >");
int thirdNum = Prompt("Введите третье число >");
System.Console.WriteLine($"Максимальное число : {CompareNumbers(firstNum, secondNum, thirdNum)}");


