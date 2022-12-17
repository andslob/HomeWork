void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
InputArray(numbers);
PrintArray(numbers);

for (int n = 0; n < numbers.Length; n++)
{
    if (numbers[n] % 2 == 0)
        count++;
}
Console.WriteLine($"{count}");