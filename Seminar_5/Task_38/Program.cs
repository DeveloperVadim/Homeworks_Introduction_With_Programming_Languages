// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементом массива.

double[] RandNum(int len)
{
    double[] array = new double[len];
    Random rand = new Random();
    for (int i = 0; i < len; i++)
        array[i] =Math.Round((rand.NextDouble()*100),1);
    return array;
}


void FindSumDiff(double[] array, int len)
{
    double min = array[0];
    double max = array[0];
    double rez = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    rez =Math.Round((max - min),1);
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {rez}");
}

void PrintArr(double[] array)
{
    foreach (double el in array)
    {
        Console.Write($"{el} ");
    }
}

Console.WriteLine("Задайте длину массива:");
int len = Convert.ToInt32(Console.ReadLine());
double[] array = RandNum(len);
PrintArr(array);
FindSumDiff(array, len);