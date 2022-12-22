// Dop1
double Dist (double a1, double b1, double a2, double b2)
{
    double dist = Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2));
    return Math.Round(dist, 2);
}

double Area (double a, double b, double c)
{
    double p = (a + b + c) / 2;
    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    return S;
}

Console.Clear();
Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double a = Dist(x1, y1, x2, y2);
double b = Dist(x2, y2, x3, y3);
double c = Dist(x1, y1, x3, y3);
Console.Write($"Стороны равны: {a}  {b}  {c}");
Console.WriteLine($"\nПлощадь треугольника равна: {Area}");
