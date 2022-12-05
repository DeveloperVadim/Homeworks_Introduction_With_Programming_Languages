// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int numA = num;

while (numA > 999) numA = numA / 10;
  
if (numA < 1000 && numA > 99)
    {
        numA = numA % 10;
        Console.WriteLine($"Третья цифра числа {num} - {numA}");
    }

else Console.Write("Третьей цифры нет");

Console.WriteLine();