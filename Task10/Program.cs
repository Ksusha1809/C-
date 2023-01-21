//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите техзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber;
SecDigit();
Console.WriteLine($" Вторая цифра числа {number} : {secondNumber}");
int SecDigit()
{
    secondNumber = number / 10 % 10;
    return secondNumber;
}