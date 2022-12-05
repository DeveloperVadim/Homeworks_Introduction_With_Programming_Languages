// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 6) Console.WriteLine("Будний день>");
  
else if (num >5 && num < 8)  Console.WriteLine("Выходной день");
    
else Console.Write("Ошибка");

Console.WriteLine();