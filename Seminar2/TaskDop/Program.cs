// task dop
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), max1 = n, max2 = -1;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (max1 < n)
    {
        max2 = max1;
        max1 = n;
    }
    else if (max2 < n)
    {
        max2 = n;
    }
}
Console.WriteLine(max2);
