// task 14

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0) // & - и, | - или
    Console.WriteLine("yes");
else
    Console.WriteLine("no");

// task 14

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0)
{
    if (n % 23 == 0)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");
}
else
    Console.WriteLine("no");
