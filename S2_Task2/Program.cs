﻿Console.Clear();


int n = new Random().Next(100, 1000); // [begin, end + 1] [10, 99]
Console.WriteLine($"Случаное число {n}");
int n1 = n / 100; 
int n2 = n % 10; 
Console.WriteLine(n1 * 10 + n2);
