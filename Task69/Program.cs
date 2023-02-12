//Задача 69: Напишите программу, которая на вход принимает два числа А и В, и
//возводит А в целею степент В с помощью ркурсии. 

Console.WriteLine("Введите  число A");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число B");
int num2 = Convert.ToInt32(Console.ReadLine());
int power = PowerNumber(num1, num2);

Console.WriteLine($"{num1} в степени {num2} равно {power}");

int PowerNumber(int number1, int number2)
{
    if (number2== 0) return 1;
    else return number1 * PowerNumber(number1, number2 - 1);
}