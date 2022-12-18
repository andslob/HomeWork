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
double min = 0;
double max = 0;

for (int n = 0; n < numbers.Length; n++)
{
    if (numbers[n] < min) 
        min = numbers[n];
        
    else if (numbers[n] > max) 
             max = numbers[n];
             
}
Console.WriteLine(max - min);