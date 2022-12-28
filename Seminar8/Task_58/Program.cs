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

void ArrayMultiplication(int[,] matrixA, int[,] matrixB, int[,] ResultArray)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            for (int m = 0; m < matrixB.GetLength(0); m++)
            {
                for (int n = 0; n < matrixB.GetLength(1); n++)
                {   
                    if(i == m && j == n)
                    {             
                        ResultArray[i, j] = matrixA[i, j] * matrixB[m, n];
                        Console.Write($"{ResultArray[i, j]} \t");
                    }
                }
                
                
            }
        }       
    }
}
Console.Clear();
Console.Write("Введите размер матрицы A: ");
int[] a = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrixA = new int[a[0], a[1]];
Console.Write("Введите размер матрицы B: ");
int[] b = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrixB = new int[b[0], b[1]];
int[,] ResultArray = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
Console.WriteLine("Матрица А:");
InputMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine("Матрица В:");
InputMatrix(matrixB);
PrintMatrix(matrixB);
Console.WriteLine("Результирующая матрица:");
ArrayMultiplication(matrixA, matrixB, ResultArray);
