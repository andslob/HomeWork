Console.Clear();


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
    n *= (-1);
while (n > 999) {

    n = n / 10;}

    if (n <= 99)
         Console.WriteLine("Третьей цифры нет");
     
    else Console.WriteLine(n % 10);


