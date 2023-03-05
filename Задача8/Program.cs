Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
for (int b = 2; b <= n; b = b + 2)
{
    Console.Write($" {b}");
}
