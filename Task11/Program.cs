//11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//456 -> 46
//782 -> 72
//918 -> 98


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
int newNumber;
NumberWithoutSecDigit();
Console.WriteLine($"Число {number} без второй цифры: {newNumber}");
int NumberWithoutSecDigit()
{
    newNumber = number / 100 * 10 + number % 10;
    return newNumber;
}


