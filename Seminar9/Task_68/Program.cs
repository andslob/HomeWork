// 68
int Akkerman(int m, int n)
{
    if (m == 0)
    
        return n + 1; 
    
    else if (n == 0 && m > 0)
     
        return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));

}


Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(m, n));