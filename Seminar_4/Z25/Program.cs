// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write($"Число {A} в натуральной степени {B} = {Exponentiation(B)}");
Console.WriteLine();

int Exponentiation(int len)
{
    if (len<0) len=len*-1;
    int exp=1;
    for (int i=1;i<=len;i++) 
        exp=exp*A;
    return exp;
}