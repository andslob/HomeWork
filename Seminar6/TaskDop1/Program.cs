// Dop1
double Dist (double a1, double b1, double a2, double b2)
{
    double dist = Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2));
    return Math.Round(dist, 2);
}

double Area (double a, double b, double c)
{
    double p = (a + b + c) / 2;
    double S = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 1);
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
double result = Area (a, b, c);
Console.WriteLine($"\nПлощадь треугольника равна: {result}");



// Console.Clear();
// double[] coord = Console.ReadLine().Split(" ").Select(x => Convert.ToDouble(x)).ToArray();
// double x1 = coord[0], y1 = coord[1], x2 = coord[2], y2 = coord[3], x3 = coord[4], y3 = coord[5];
// double AB = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// double BC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
// double AC = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
// double p = (AB + BC + AC) / 2;
// double S = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
// Console.WriteLine(Math.Round(S, 2));
