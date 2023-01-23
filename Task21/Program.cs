//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите кординаты точки");
Console.WriteLine("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты точки");
Console.WriteLine("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z1: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1,z1,x2, y2, z2);
double dRoud = Math.Round(distance, 2 , MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками с координатаи  A ({x1};{y1};{z1}) и B ({x2};{y2};{z2}) в 2D пространсте {dRoud}");

double Distance (int xa, int ya, int za, int xb, int yb, int zb)
{
    int cat1 = xb- xa;
    int cat2 = yb -ya;
    int cat3 = zb -za;
    double result = Math.Sqrt(cat1* cat1 + cat2 * cat2 + cat3 * cat3);
    return result;
}
