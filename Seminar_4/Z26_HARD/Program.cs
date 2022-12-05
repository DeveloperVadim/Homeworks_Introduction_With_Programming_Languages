// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход 
// целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

int CountFra (decimal num)
{
int count=0;
while (num!=(int)num)
{
    num*=10;
    count++;
}
return count;
}

int CountInt (decimal num)
{
int count=0;
if (num<1) count=1;
while (num>1)
{
    num/=10;
    count++;
}    
return count;
}

Console.WriteLine("Введите число ");
decimal num = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine(CountFra(num)+CountInt(num));


