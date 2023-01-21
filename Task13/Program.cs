﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 > 0) Console.WriteLine($"Третьей цифрой числа {number} является цифра {number / 100 % 10}");
else Console.WriteLine($"У числа {number} нет третьей цифры");

Console.WriteLine();