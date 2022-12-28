// 58
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void SumRowElement(int[,] matrix, int[] array)
{
    for (int k = 0; k < matrix.GetLength(0)-1; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                array[k] = array[k] + matrix[i, j];
            }
        }
        int min = 0;
        array[0] = min;
        for (k = 1; k < matrix.GetLength(0); k++)
        {
            int temp = array[0];
            if (array[k] < array[0])
            {
                min = array[k];
            }
            Console.WriteLine($"{min}-минимальная сумма, {k}-строка");
        }
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int k = 0;
int[] array = new int[k];
Console.WriteLine("Массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
SumRowElement(matrix, array);
