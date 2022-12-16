// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// Вариант 1
int[] FillArray(int len)
{
int[] arr = new int[len];
for (int i = 0; i < len; i++)
{
    Console.WriteLine($"Введите {i + 1}-е число:");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
return arr;
}

void PrintResult(int[] array) 
{
    int count=0;
    Console.Write("Числа: ");
    foreach (int el in array)
    {
        Console.Write($"{el} ");
        if (el>0) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чисел больше 0: "+count);
}

Console.WriteLine("Введите количество чисел: ");
int len =Convert.ToInt32(Console.ReadLine());
int[] array=FillArray(len);
PrintResult(array); 
Console.WriteLine();



// Вариант 2
// int CounterNum(int len)
// {
// int count=0;
// int i=1;
// while (i<=len)
// {
// Console.WriteLine($"Введите {i}-е число: ");
// int num =Convert.ToInt32(Console.ReadLine());
// if (num>0) count++;
// i++;
// }
// return count;
// }

// Console.WriteLine("Введите количество чисел: ");
// int len =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Количество чисел больше 0: "+CounterNum(len));
// Console.WriteLine();