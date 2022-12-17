// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 11);
}

void AverageCols(int[,] array, int[] sum) // Доработать 
{
    for (int i = 0; i < array.GetLength(0); i++)
          
        for (int j = 0; j < array.GetLength(1); j++)
            sum[i] += array[j, i];

    Console.Write("Среднее арефметическое каждого столбца: ");
    foreach (double elem in sum)
    {
        Console.Write($"{Math.Round(elem / array.GetLength(1), 1)}   ");
    }
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
int[] sum = new int[array.GetLength(1)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
AverageCols(array, sum);