//20. Напишите программу, которая 
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D 
// пространстве.

Console.WriteLine("Введите кординаты точки");
Console.WriteLine("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты точки");
Console.WriteLine("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, x2, y2);
double dRoud = Math.Round(distance, 2 , MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками с координатаи  A ({x1};{y1}) и B ({x2};{y2}) в 2D пространсте {dRoud}");

double Distance (int xa, int ya, int xb, int yb)
{
    int cat1 = xb- xa;
    int cat2 = yb -ya;
    double result = Math.Sqrt(cat1* cat1 + cat2 * cat2);
    return result;
}
