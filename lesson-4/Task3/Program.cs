// Задача 3: Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

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


