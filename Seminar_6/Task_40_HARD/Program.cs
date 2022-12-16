// Задача 40 - HARD необязательная. На вход программы подаются три целых положительных 
// числа. Определить , является ли это сторонами треугольника. Если да, то вывести всю 
// информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.

void TriangleCheck(double A, double B, double C)
{
    if (A < B + C & B < C + A & C < A + B)
    {
        Console.WriteLine("Треугольник с такими сторонами существует ");

        double perimeterTriangle = A + B + C;
        Console.WriteLine("Периметр треугольника: " + perimeterTriangle);

        double p = perimeterTriangle / 2;
        double areaTriangle = Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 3);
        Console.WriteLine("Площадь треугольника: " + areaTriangle);

        double angleA = Math.Round((Math.Acos(
            (Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) / (2 * A * C)
            ) * (180.0 / Math.PI)), 3);
        double angleB = Math.Round((Math.Acos(
            (Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) / (2 * A * B)
            ) * (180.0 / Math.PI)), 3);
        double angleC = Math.Round((Math.Acos(
            (Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) / (2 * C * B)
            ) * (180.0 / Math.PI)), 3);
        Console.WriteLine($"Углы треугольника A:{angleA} B:{angleB} C:{angleC} ");
        if (A == B & B == C & C == A)
        {
            Console.WriteLine("Треугольник равносторонний ");
        }
        else if (A == B || B == C || C == A)
        {
            Console.WriteLine("Треугольник равнобедренный ");
        }
        else if (angleA == 90 || angleB == 90 || angleC == 90)
        {
            Console.WriteLine("Треугольник прямоугольный ");
        }

    }
    else Console.WriteLine("Треугольник с такими сторонами не существует ");
}

try
{
    Console.WriteLine("Введите сторону A треугольника:");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите сторону B треугольника:");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите сторону C треугольника:");
    int C = Convert.ToInt32(Console.ReadLine());
    TriangleCheck(A, B, C);
}

catch
{
    Console.WriteLine("Ошибка ввода, введите целые числовые значения!");
}