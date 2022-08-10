// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

void randomArray (int[] array){
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(1, 10);
    }
}
int[] array = new int[3];
randomArray(array);
System.Console.WriteLine($"{array[0]}{array[1]}{array[2]}");
System.Console.WriteLine($"{array[0]}{array[2]}");
