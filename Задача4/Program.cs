Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-ие число: ");
int b = int.Parse(Console.ReadLine()!);
int max = n;
if (max < m)
max = m;    
if (max < b)
max = b;
Console.WriteLine($"Максимальное число: {max}");