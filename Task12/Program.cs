



Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result;
Remains(number1, number2);
int Remains(int num1, int num2)
{
    result = num1 % num2;
    return result;
}
if (result == 0) Console.WriteLine($"Число {number1} кратно числу {number2}");
else
{
    Console.WriteLine($"Число {number1} не кратно числу {number2}, остаток от деления равен {number1 % number2}");
}