// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}
string CompareNumbers(int firstNum, int secondNum)
{
    string result;
    if (firstNum > secondNum)
    {
        result = $"Число {firstNum} больше чем {secondNum}";
    }
    else
    {
        result = $"Число {secondNum} больше чем {firstNum}";
    }
    if (firstNum == secondNum)
    {
        result = $"Число {firstNum} равно {secondNum}";
    }
    return result;
}

int firstNum = Prompt("Введите первое число >");
int secondNum = Prompt("Введите второе число >");
System.Console.WriteLine(CompareNumbers(firstNum, secondNum));


