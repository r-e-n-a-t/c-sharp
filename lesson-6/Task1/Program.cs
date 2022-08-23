// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string Prompt(string message)
{
    System.Console.Write(message);
    string result = Console.ReadLine();
    // int result = int.Parse(value);
    return result;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}
int[] CreateArrNum()
{   
    int count = 0;
    string number = "";
    int[] tempArray = new int[1000];
    System.Console.WriteLine($"Для выхода из ввода чисел введите 'exit'");
    for (count = 0; number != "exit"; count++)
    {
        number = Prompt($"Введите число {count+1}>");
        if (number != "exit") 
        {
            tempArray[count] = int.Parse(number);
        }
    }
    int[] array = new int[count-1];
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = tempArray[i];
    }
    return array;
}
void FindMoreZeroNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Количество введённых чисел больше 0 => {count}");
}
int[] arr = CreateArrNum();
ShowArray(arr);
FindMoreZeroNum(arr);



