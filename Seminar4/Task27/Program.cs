// task 27
int Sum(int n)
{

    int count = Convert.ToString(n).Length;
    int res = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        res = n - n % 10;
        result = result + (n - res);
        n = n / 10;
    }
    return result;
}
Console.Clear();
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = Sum(n);
Console.WriteLine("Сумма: " + sum);
