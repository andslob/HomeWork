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

void SumRowElement(int[,] matrix)
{
    int index = 0;
    int min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int SumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow += matrix[i, j];
        }

        if (min > SumRow)
        {
            min = SumRow;
            index = i + 1; // для ползователя нумерация строк с 1
        }
    }
    Console.WriteLine($"{min}-минимальная сумма, {index}-строка");
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
SumRowElement(matrix);