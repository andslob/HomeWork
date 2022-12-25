// 50
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
} 



Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.Write("Введите позицию элемента матрицы: ");
int[] position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (position[0] > size[0] || position[1] > size[1] || position[0] < 0 || position[1] < 0)
{
    Console.Write("Вы ошиблись!\nВведите позицию элемента матрицы: ");
    position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
Console.WriteLine(matrix[position[0] - 1, position[1] - 1]);




