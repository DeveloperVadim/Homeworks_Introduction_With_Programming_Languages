// Задача 19 - HARD необязательная
//  Напишите программу, которая принимает на вход целое число любой разрядности и 
// проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0, mun = num;

while (mun > 0)
{
    sum = sum * 10 + mun % 10;
    mun /= 10;
}
if (sum == num)
    Console.WriteLine($"Число {num} является полиндромом.");
else Console.WriteLine($"Число {num} не является полиндромом, обратная запись числа: {sum}.");
