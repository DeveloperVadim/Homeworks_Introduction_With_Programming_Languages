// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое 
// число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ввод  первого числа ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввод второго числа ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA>numB) 
{
    Console.WriteLine($"Максимальное число {numA}");
    Console.WriteLine($"Минимальное число {numB}");
}
if (numB>numA) 
{
    Console.WriteLine($"Максимальное число {numB}");
    Console.WriteLine($"Минимальное число {numA}");
}
if (numA==numB) 
{
    Console.WriteLine("Числа равны");
}
Console.WriteLine();