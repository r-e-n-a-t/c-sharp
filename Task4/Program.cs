// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int num = Prompt("Введите число >");
int count = 1;
while (count <= num) {
    if ((count % 2) == 0)
    {
        System.Console.Write($"{count}, ");
    }
    count++;
}

// System.Console.WriteLine(ParityCheck(num));