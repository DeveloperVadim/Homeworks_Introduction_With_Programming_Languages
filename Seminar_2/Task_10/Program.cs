// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000) // проверка на трехзначное число
{
    int numA = num / 10 % 10; // 2я цифра трехзначного числа
    Console.WriteLine($"Вторая цифра трехзначного числа - {numA}");
}
else
{
    Console.WriteLine("Вы ввели не верное число ");
}
Console.WriteLine();