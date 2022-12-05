// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandNum(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void FindEven(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве = {count}");
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
FindEven(array);