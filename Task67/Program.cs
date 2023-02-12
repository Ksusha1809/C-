//Задание 67. Напишиту программу, которая будет принимать на вход число и
//возвращать сумму его цифр.
//453->12
//45->9

Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(num);
Console.WriteLine($"Сумма цифр числа равна {sumNumber}");

int SumNumber (int number)
{
    if (number == 0) return 0;
    else return number % 10 +SumNumber(number / 10);
}