// Task 25

int Exp(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++){
        res = res * a;}
    return res;
}

Console.Clear();
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = Exp(a, b);
Console.WriteLine("Вывод: " + stepen);