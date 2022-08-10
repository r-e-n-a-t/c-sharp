//Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int num = int.Parse(value);
    string result = "Такого дня недели нет :)";
    if (num > 0 && num < 8)
    {
        result = "Рабочий день";

        if (num == 6 || num == 7)
        {
            result = "Выходной";
        }
    }
    return result;
}

string message = Prompt("Введите номер дня недели>");
System.Console.Write(message);



