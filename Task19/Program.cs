//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите целое число:   ");
        string number = Console.ReadLine();
        int length = number.Length;
        string txtToCheck = number.Replace(" ", "");

        bool IsPalindrome()
        {
            for (int i = 0; i < length / 2; i++)
                while (number[i] == number[length - 1])
                {
                    return true;
                }
            return false;
        }

        if (IsPalindrome()) Console.WriteLine($"Введный текст/число - {number} - является палиндромом");
        else Console.WriteLine($"Число {number} не является палиндромом");
        Console.WriteLine();
    }
}