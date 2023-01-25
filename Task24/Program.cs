//Задача 24: Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму чисел
//от 1 до А.
//7 -> 28
//4 -> 10

Console.WriteLine("Введите целое положительно число");
int number = Convert.ToInt32(Console.ReadLine());

int sumnumbers = Sumnumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumnumbers}");

int Sumnumbers(int num)
{
    int sum =0;
    for (int i = 1; i <= num; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}