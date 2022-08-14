Console.WriteLine("Введите число b1:");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k1:");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b2:");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k2:");
int k2 = Convert.ToInt32(Console.ReadLine());


if (k1==k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (b2-b1)/(k1-k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"Точка пересечения:{x},{y}");
}


