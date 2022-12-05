// Задача 21 - HARD необязательная 
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, 
// потом задаются координаты точек.

Console.WriteLine("Введите размерность N");
int N = Convert.ToInt32(Console.ReadLine());
double[] mas = new double[N];
double sum = 0;
double dist = 0;

int[] X = new int[N];
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите {1 + i} координату первой точки:");
    X[i] = Convert.ToInt32(Console.ReadLine());
}

int[] Y = new int[N];
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите {1 + i} координату второй точки:");
    Y[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < N; i++)
{

    mas[i] =Math.Pow((Y[i] - X[i]), 2);
    sum = sum + mas[i];
    dist = Math.Sqrt(sum);
    if (i == N - 1) 
    {
    dist = Math.Round(dist,2);  
    Console.WriteLine($"Расстояние между двумя точками в {N} D пространстве: {dist}");
    }
}

Console.WriteLine();