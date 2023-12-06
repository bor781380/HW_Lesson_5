// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца
// Пример:
// 4 3 1 => 2 6
// 2 6 9    4 6
// 4 6 2

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

void ReducedArray(int[,] arr)
{
    int min = arr[0, 0];
    int linemin = 0;
    int columnmin = 0;
    int[,] rarray = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                linemin = i;
                columnmin = j;
            }
        }
    }
    int s=0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        if (i!=linemin)
        {
            int d=0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j!=columnmin) rarray[(i-s),(j-d)] = arr[i,j];
                else d=d+1;
            }
        }
        else s=s+1;
    }
    Console.WriteLine($"Из массива удалена строка с индексом {linemin} и столбец с индексом {columnmin} содержащие минимальное значение {min}", linemin, columnmin, min);
    Console.WriteLine("Итоговый массив:");
    PrintArray(rarray);
}

int[,] newArray = GetArray(5, 4, 0, 10);
PrintArray(newArray);
ReducedArray(newArray);
