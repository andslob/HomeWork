void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(Console.ReadLine());
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
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
InputArray(numbers);
PrintArray(numbers);
int result = 0;
for (int n = 0; n < numbers.Length; n++)
{

    if (numbers[n] > 0)
        result = result + 1;
}
Console.WriteLine(result);