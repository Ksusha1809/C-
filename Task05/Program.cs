Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    int count = -num;
    while (count <= num)
    {
        Console.WriteLine(count + " ");
        count++;
    }
}
else
{
    Console.WriteLine("Число должно быть > 0");
}