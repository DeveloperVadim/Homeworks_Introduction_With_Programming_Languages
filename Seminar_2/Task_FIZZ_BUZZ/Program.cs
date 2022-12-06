// Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран 
// числа от 1 до 100. При этом вместо чисел, кратных трем, программа должна выводить 
// слово Fizz, а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати, 
// то программа должна выводить слово FizzBuzz. Задача может показаться очевидной, но 
// нужно получить наиболее простое и красивое решение.

for (int i = 1; i <= 100; i++)
{
    string str = "";
    if (i % 3 == 0) str += "Fizz";
    if (i % 5 == 0) str += "Buzz";
    // Console.Write(str);
    string s3=i.ToString();
    if (str == "") str = s3;
    //if (i % 3 > 0 || i % 3 < 0 || i % 5 > 0 || i % 5 < 0) Console.Write($" {i} ");
    Console.WriteLine(str);
}



// int n=100;
// {
//     for (int i = 1; i <= n; i++)
//     {
//         if (i % 15 == 0) 
//             Console.Write("FizzBuzz "); 
//         else if (i % 3 == 0) 
//             Console.Write("Fizz ");
//         else if (i % 5 == 0) 
//             Console.Write("Buzz ");
//         else 
//             Console.Write($"{i} ");
//     }
// }