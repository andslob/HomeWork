// Task 23
Console.Clear();
Console.Write("Введите число A: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
    Console.Write($"{i * i * i} ");
