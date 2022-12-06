// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandNum(int len)
{
    int[] array = new int[len];
    Random rand = new Random();
    for (int i = 0; i < len; i++)
        array[i] = rand.Next()%(len*10);
    return array;
}


void FindSumOdd(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2>0) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма не четных чисел в массиве = {count}");
}

void PrintArr(int[] array)
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
}

Console.WriteLine("Задайте длину массива:");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = RandNum(len);
PrintArr(array);
FindSumOdd(array);