﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите  число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число B");
int B = Convert.ToInt32(Console.ReadLine());


ToDegree(A, B);

void ToDegree(int a, int b)
{
    int result = 1;
    if ( B <0)
    {
       Console.WriteLine("Введено некорректное значение. Введите натуральное число B.");
    }
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

