Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 400 == 0 || n % 100 != 0 && n % 4 == 0) // ; не ставить 
    Console.WriteLine("yes");
else 
{
    Console.WriteLine("no");
}