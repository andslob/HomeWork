void Input(int[] n)
{
    for (int i = 0; i < n.Length; i++)
        n[i] = new Random().Next(-100, 100);
}
void Print(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}



Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] n = new int[size];

int res = 0;
for (int i = 0; i < n.Length; i++)
{
    if (i % 2 == 0)
        res = res + n[i];
}
return res;
Input(n);
Console.Write(n);
Print(n);
Console.WriteLine(res);