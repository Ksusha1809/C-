//16. Напишите программу, которая принимает на
//вход два числа и проверяет, является ли одно
//число квадратом другого.
//5,25 -> 
//-4,16 -> да
//8,9 -> да

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool isSquare = IsSquare(number1, number2);

Console.WriteLine(isSquare ? "ДА" : "НЕТ");

bool IsSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1*num1;
}