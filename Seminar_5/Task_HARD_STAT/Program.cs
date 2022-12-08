// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите 
// максимальный элемент и его индекс, минимальный элемент и его индекс, среднее 
// арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести 
// на экран с пояснениями. Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

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

void FindSumUnev(int[] array, int len)
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
    Console.WriteLine();
    Console.WriteLine($"Мин знач.:{min} Мин инд.:{minI} Макс знач.:{max} Макс инд.:{maxI} Ср. арефм.:{sum}");
}

void SelectionSort(int[] array,int len) 
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

int MedianNum(int[] array,int len)
{
    int median=0;
    for (int i = 0; i < len - 1; i++)
    {
        if (len%2==1)median=array[(len-1)/2]; // нечетная длина массива
        if (len%2==0)median=(array[len/2] +array[(len/2)-1])/2; // четная длина массива
       
    }
    return median;
}

Console.WriteLine("Задайте длину массива:");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = RandNum(len);
PrintArr(array);
FindSumUnev(array, len);
SelectionSort(array, len);
PrintArr(array);
Console.WriteLine();
 Console.WriteLine($"Медианное значение: {MedianNum(array,len)}");