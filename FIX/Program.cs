
// int[] RandArr(int len) // создание рандомного массива
// {
//     int[] array = new int[len];
//     Random rand = new Random();
//     for (int i = 0; i < len; i++)
//         array[i] = rand.Next() % (len * 10);
//     return array;
// }

void PrintArr(int[] array) // вывод массива
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.Write(":Исходный массив ");
}

void PrintArr2(int[] array) // вывод массива
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.Write(":Отсортированный массив от Max к Min ");
}

void PrintArr3(int[] array) // вывод массива
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.Write(":Перемешанный массив ");
}

int[] RandArr(int len)
{
int[] array = new int[len];
Random rnd = new Random();
int i = 0;
while (i < len)
{
  int temp = rnd.Next(len);
  if (array[temp] == 0)
  {
    array[temp] = i;
    ++i;
  }                
}
  return array;
}

void SelectionSort(int[] array, int len) // сортировка массива от max к min
{
    for (int i = 0; i < len - 1; i++)
    {
        int maxPos = i;
        for (int j = i + 1; j < len; j++)
        {
            if (array[j] > array[maxPos])
            {
                maxPos = j;
            }
        }
        int tmp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = tmp;
    }
}

void SelectionSort2(int[] array, int len) // сортировка случайным образом
{
    Random rand = new Random();
 
    for (int i = len - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);
 
        int tmp = array[j];
        array[j] = array[i];
        array[i] = tmp;
    }
}

Console.WriteLine("Задайте длину массива:");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = RandArr(len);
PrintArr(array);
Console.WriteLine();
SelectionSort(array, len);
PrintArr2(array);
Console.WriteLine();
SelectionSort2(array, len);
PrintArr3(array);