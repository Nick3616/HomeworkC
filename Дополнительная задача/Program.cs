Console.Clear();
int[] a = { 1, 2, 3, 4, 8, 6, 7, 0, 8, 9, 10 };
int b = 0;
int c = 0;
int max = 0;
int max2 = 0;
for (b = 0; b < a.Length; b++)
{
    if (a[b] == 0)
        c = b;
}
for(b = 0; b < c; b++)
{
    if (a[b] > max)
    {
        max2 = max;
        max = a[b];
    }

    else if (a[b] > max2)
    {
        max2 = a[b];
    }
}
Console.Write(max2);