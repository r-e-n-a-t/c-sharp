// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[] Prompt()
{   
    string[] msgArray = new string[] {"'x' точки А", "'y' точки А", "'z' точки А", "'x' точки B", "'y' точки B", "'z' точки B"};
    int[] numArray = new int[6];
    for (int i = 0; i < 6; i++) {
        System.Console.Write($"Введите координату {msgArray[i]} > ");
        string value = Console.ReadLine();
        numArray[i] = int.Parse(value);
    }
    return numArray;
}
double PointLength(int[] crd) 
{
    double result = Math.Sqrt(((crd[3] - crd[0]) * (crd[3] - crd[0])) + ((crd[4] - crd[1]) * (crd[4] - crd[1])) + ((crd[5] - crd[2]) * (crd[5] - crd[2])));
    return result;
}
int[] numArray = Prompt();
System.Console.Write(PointLength(numArray));