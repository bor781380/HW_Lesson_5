// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
//Пример
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FlipOverArray(int[,] arr)
{
    int[] temparr = new int[arr.GetLength(0)];
    int i=0;
    for (int j = 0; j < arr.GetLength(1); j ++)
    {
        temparr[i] = arr[i,j];
        arr[i,j] = arr[arr.GetLength(0)-1,j];
        arr[arr.GetLength(0)-1,j]=temparr[i];
    }
Console.WriteLine("первая и последняя строки массива поменяны местами");  
}

int[,] newArray = GetArray(3, 4, 0, 10);
PrintArray(newArray);
FlipOverArray(newArray);
PrintArray(newArray);