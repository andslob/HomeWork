// Task 36

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
void PrintArray(int[] numbers)
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
int[] numbers = new int[size];
int count = 0;
int res = 0;
InputArray(numbers);
PrintArray(numbers);

for (int n = 0; n < numbers.Length; n++)
{
    if (n % 2 != 0) res = res + numbers[n];
        count++;
}
Console.WriteLine(res);