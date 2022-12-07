Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 || n == 7)
    Console.WriteLine ("ВЫХОДНОЙ");
if (n == 1)
    Console.WriteLine("Понедельник, трудимся");
else if (n == 2)
    Console.WriteLine("Вторник, трудимся");
else if (n == 3)
    Console.WriteLine("Среда, трудимся");
else if (n == 4)
    Console.WriteLine("Четверг, трудимся");
else if (n == 5)
    Console.WriteLine("Пятница, трудимся");
else if (n == 6)
    Console.WriteLine("Суббота");
else
    Console.WriteLine("Воскресенье");
