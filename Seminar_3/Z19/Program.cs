// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num % 100 % 10;
    int num5 = num % 10;

    if (num1 == num5 || num2 == num4)
        Console.WriteLine($"Число {num} является полиндромом.");
    else Console.WriteLine($"Число {num} не является полиндромом.");
}

else Console.WriteLine("Число не пятизначное! ");
Console.WriteLine();