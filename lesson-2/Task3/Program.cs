// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string Prompt(string message)
{
    System.Console.Write(message);
    string result = Console.ReadLine();
    if (result.Length < 3)
    {
        result = "error";
    }
    return result;
}

string message = Prompt("Введите число >");
if (message == "error")
{
    System.Console.Write("Третьей цифры нет");
}
else
{
    System.Console.Write(message[2]);
}


