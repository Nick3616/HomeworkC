Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
if (n > m)
    Console.WriteLine($"max = {n} min = {m}");
else
    Console.WriteLine($"max = {m} min = {n}");