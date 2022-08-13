// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}
void cubedNum(int num) {
    for (int i = 1; i <= num; i++) {
    System.Console.Write(i * i * i + "  ");
    }
}
int message = Prompt("Введите число >");
System.Console.WriteLine($"Таблица кубов чисел от 1 до {message}:");
cubedNum(message);