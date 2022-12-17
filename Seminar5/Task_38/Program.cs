// Task 38

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}
void PrintArray(double[] numbers)
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
double[] numbers = new double[size];
InputArray(numbers);
PrintArray(numbers);
double min = Convert.ToDouble(Console.ReadLine());
double max = Convert.ToDouble(Console.ReadLine());

for (int n = 0; n < numbers.Length; n++)
{
    if (min > numbers[n]) 
        min = numbers[n];
        
    if (max < numbers[n]) 
        max = numbers[n];
}
Console.WriteLine($"{max - min}");