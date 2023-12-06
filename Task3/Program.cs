// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// Пример:
// 4 3 1 => Строка с индексом 0
// 2 6 9
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

void SummLine(int[,] arr)
{
    int summ = 0;
    int summmax = 0;
    int[,] line=new int[arr.GetLength(0),2];
    for (int i = 0; i < arr.GetLength(0);i++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        {
            summ += arr[i,j];
        }
    line[i,0] = i;
    line[i,1] = summ;
    if(summ>summmax) summmax=summ;
    summ =0;
    }
    for(int i=0; i<line.GetLength(0);i++)
    {
        if(line[i,1] == summmax) Console.WriteLine($"Наибольшая сумма:{summmax}, в строке с идексом: {i}", summmax, i);
    }
}

int[,] newArray = GetArray(5, 3, 0, 10);
PrintArray(newArray);
SummLine(newArray);
