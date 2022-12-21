// task1
Console.Clear();

Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > a) 
    Console.WriteLine("Результат: ", b);
else
    Console.WriteLine("Результат: ", a);
