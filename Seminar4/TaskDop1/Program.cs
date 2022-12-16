// Task Dop1
// string[] s = Console.ReadLine().Split("а"); // 
// for (int i = 0; i < s.Length; i++)
//     Console.WriteLine(s[i]);




// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значения элементов массива: ");

// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
// {                                          
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"[{string.Join(", ", array)}]");


// int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// for (int i = 0; i < s.Length; i++)
//     Console.WriteLine(s[i] * 10);


// int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// foreach (int element in s)
//     Console.WriteLine(element * 2);
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int k = Convert.ToInt32(Console.ReadLine());
int[] result = new int[numbers.Length];
k %= n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        result[i] = numbers[numbers.Length - k + i];
    for (int i = 0; i < numbers.Length - k; i++)
        result[k + i] = numbers[i];
    Console.WriteLine($"{string.Join(" ", result)}");
}
else
{
    k = k * (-1);
    for (int i = 0; i < k; i++)
        result[numbers.Length - k + i] = numbers[i];
    for (int i = 0; i < numbers.Length - k; i++)
        result[i] = numbers[k + i];
    Console.WriteLine($"{string.Join(" ", result)}");
}
