﻿//17. Напишите программу, которая принимает на вход
//координаты точки(X и Y), причем X <>0 и Y <>0 и выдаёт
//номер четверти плоскости, в которой находится эта
//точка.

Console.WriteLine("Введите кординаты точки");
Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string resuit = quarter > 0 
? $" Указанные координаты соотвествуют четверти -> {quarter}"
: "Введены некорректные координаты";

Console.WriteLine(resuit);

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}