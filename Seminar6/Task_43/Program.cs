Console.Clear();
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;
if ((k1 == k2) && (b1 == b2))
{
    Console.Write("Прямые параллельны");
}
else if (k1 == k2)
{
    Console.Write("Прямые сопадают");
}
else x = ((b2 - b1) / (k1 - k2));
y = (k1 * (b2 - b1) / (k1 - k2) + b1);
Console.WriteLine($"{x}, {y}");
