// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите 
// максимальный элемент и его индекс, минимальный элемент и его индекс, среднее 
// арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести 
// на экран с пояснениями. Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

void PrintArr2(int[] array)
{

    Console.Write("Массив2: ");
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Мин знач.:{array[0]} Мин инд.:{array[1]} Макс знач.:{array[2]} Макс инд.:{array[3]} Ср. арефм.:{array[4]}");
}

void PrintArr(int[] array)
{

    Console.Write("Массив: ");
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
}

int[] RandNum(int len)
{
    int[] array = new int[len];
    Random rand = new Random();
    for (int i = 0; i < len; i++)
        array[i] = rand.Next() % (len * 10);
    return array;
}

int[] FindArr2(int[] array, int len)
{
    int min = array[0];
    int minI = 0;
    int max = array[0];
    int maxI = 0;
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        sum += array[i];
        if (array[i] > max)
        {
            max = array[i];
            maxI = i;
        }

        if (array[i] < min)
        {
            min = array[i];
            minI = i;
        }
    }
    sum = sum / len;
    int[] array2 = new int[5];
    array2[0] = min;
    array2[1] = minI;
    array2[2] = max;
    array2[3] = maxI;
    array2[4] = sum;
    return array2;
}

void SelectionSort(int[] array, int len)
{
    for (int i = 0; i < len - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < len; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int MedianNum(int[] array, int len)
{
    int median = 0;
    for (int i = 0; i < len - 1; i++)
    {
        if (len % 2 == 1) median = array[(len - 1) / 2]; // нечетная длина массива
        if (len % 2 == 0) median = (array[len / 2] + array[(len / 2) - 1]) / 2; // четная длина массива

    }
    return median;
}

Console.WriteLine("Задайте длину массива:");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = RandNum(len);
int[] array2 = FindArr2(array, len);
PrintArr(array);
Console.WriteLine();
//FindArr2(array, len);
SelectionSort(array, len);
PrintArr(array);
Console.WriteLine();
Console.WriteLine($"Медианное значение: {MedianNum(array, len)}");
PrintArr2(array2);
Console.WriteLine();
