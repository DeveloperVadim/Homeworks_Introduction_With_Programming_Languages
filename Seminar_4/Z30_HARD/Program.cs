// Задача 30: - HARD необязательная Напишите программу, которая выводит массив 
// из 8 элементов, заполненный нулями и единицами в случайном порядке.. Далее надо 
// посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE 
// на экран, иначе вывести False.

int[] Rendr(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

// bool MoreNum(int[] array)
// {
//     int sum_1 = 0;
//     int sum_0 = 0;
//     foreach (int el in array)
//     {
//         Console.Write($"{el} ");
//         if (el > 0) sum_1 += el;
//         else sum_0++;
//     }

//     bool res = false;
//     if (sum_1 > sum_0) res = true;
//     return res;
// }

bool MoreNum(int[] array,int len)
{
    int sum_1 = 0;
    foreach (int el in array)
    {
        Console.Write($"{el} ");
        if (el > 0) sum_1 += el;
    }

    bool res = false;
    if (sum_1 > len/2) res = true;
    Console.WriteLine();
    return res;
}

int len = 8;
int[] array = Rendr(len);
Console.WriteLine(MoreNum(array,len));
Console.WriteLine();