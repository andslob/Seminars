﻿// task1
Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m * m == n) // != (неравно)
    Console.WriteLine("yes");
if (n * n == m) // != (неравно)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
