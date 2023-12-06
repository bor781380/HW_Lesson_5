// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Пример
// 4 3 1 (1,2) => 9
// 2 6 9

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

void SearchElementInArray(int[,] arr)
{
    Console.Write("Введите номер строки в котором содержится элемент :");
    string? n = Console.ReadLine();
    Console.Write("Введите номер столбца в котором содержится элемент :");
    string? m = Console.ReadLine();
    if (String.IsNullOrWhiteSpace(n)==true || String.IsNullOrWhiteSpace(m)==true)
    {
        Console.WriteLine("Введено пустое значение, повторите ввод.");
    }
    else
    {
        int i = Convert.ToInt32(n) - 1;
        int j = Convert.ToInt32(m) - 1;
        if (i + 1 > arr.GetLength(0) || j + 1 > arr.GetLength(1))
        {
            Console.WriteLine("Такого элемента нет!");
        }
        else
        {
            Console.WriteLine(arr[i, j]);
        }
    }
    


}

int[,] newArray = GetArray(3, 3, 0, 10);
PrintArray(newArray);
SearchElementInArray(newArray);



