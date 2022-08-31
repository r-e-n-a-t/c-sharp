// 

void CreateFrame(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == 0 || i == array.GetLength(0)) array[i, j] = 1;
            if(j == 0 || j == array.GetLength(0)) array[i, j] = 1;
        }
    }
}
void showTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = new int[20, 40];
string FigureSymbol = "██";
CreateFrame(matrix);
showTwoDimArray(matrix);