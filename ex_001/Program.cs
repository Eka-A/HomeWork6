int count = 0;
Console.WriteLine("Сколько чисел требуется ввести?");
int m = Convert.ToInt32(Console.ReadLine());

for (int i=0; i<m; i++)
{
    Console.Write($"Введите {i+1} число:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num>0) count++;
}

Console.WriteLine("Было введено:" + count);




