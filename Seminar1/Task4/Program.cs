Console.Clear();

Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) 
    max = b;
if (c > max)
    max = c;
else
    max = a;
Console.WriteLine(max);