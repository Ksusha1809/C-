//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine("Введите  число");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(number);
Console.WriteLine($"Cумма цифр в числе {number} -> {sumNumber} ");

int SumNumber(int num)
{
    int sum = 0;
    if (num < 0)
    {
        num = num * -1;
    }
    int count = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num /10;
        count++;
    }
    return sum;
}