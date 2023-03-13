Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100)
{
    Console.Write("Третьей цифры нет");
    return;
}
string m = Convert.ToString(n);
Console.Write(m[2]);