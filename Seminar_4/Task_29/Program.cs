// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с 
// клавиатуры и выводит массив на экран.

int[] ArrayNumbs(int len)
{
int[] arr = new int[len];
for (int i = 0; i < len; i++)
{
    Console.WriteLine($"Введите {i + 1}й элемент массива:");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
return arr;
}

int len = 8;
int[] arr=ArrayNumbs(len);
for (int i = 0; i < len; i++)
{
    Console.Write($"{arr[i]} ");
}
// Array.ForEach(ArrayNumbs(len), Console.Write);
Console.WriteLine();