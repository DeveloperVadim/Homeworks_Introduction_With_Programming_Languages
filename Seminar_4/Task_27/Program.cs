// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {num} = {SumDigits(num)}");
Console.WriteLine();