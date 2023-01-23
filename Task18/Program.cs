//18. Напишите программу, которая по 
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти.

Console.WriteLine("Введите номер координатной четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string resuit = Quarter(quarter);
Console.WriteLine(resuit);

string Quarter( int coords)
{
    if (coords == 1) return ("x > 0, y > 0");
    if (coords == 2) return ("x < 0, y > 0");
    if (coords == 3) return ("x < 0, y < 0");
    if (coords == 4) return ("x > 0, y < 0");
    return ("Введены некорретные данные");
}