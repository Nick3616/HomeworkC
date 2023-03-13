Console.Clear();
Console.Write("Введите цифру дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 4 && n < 8)
    Console.Write("Да");
else
    Console.Write("Нет");