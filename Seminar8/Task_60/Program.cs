// 60
void InputMatrix(int[,,] matrix)
{   
    int n = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = n++;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            for (int k = 0; k < matrix.GetLength(1); k++)
            Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k})");
        Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите размер трехмерного массива: ");
int[] a = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (a[0] * a[1] * a[2] > 90)
{
    Console.Write("Вы ошиблись!\nВведите размер трехмерного массива: ");
    a = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] matrixA = new int[a[0], a[1], a[2]];
Console.WriteLine("Матрица А:");
InputMatrix(matrixA);
PrintMatrix(matrixA);

