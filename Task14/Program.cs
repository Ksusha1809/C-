//14. Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно
//одновременно 7 и 23.
//14 -> нет
//46 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool mult = Mult(number);
bool Mult (int num1)
{
    return num1 % 7 == 0 && num1 % 23 ==0;
}
Console.WriteLine(mult?"ДА":"НЕТ");