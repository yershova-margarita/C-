/*
 Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

// double d = 5.099864545;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero); - округление до 2х цифр
// double sqrt = Math.Sqrt(5); - извлечение корня
// Math.Pow(23,5) - возведение в степень 23 ^ 5

double Distance(double x1, double y1, double x2, double y2) 
{
    double sqrt = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return Math.Round(sqrt, 2, MidpointRounding.ToZero);
}
Console.WriteLine("Введите первой точки :");
Console.Write("x1 = ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второй точки :");
Console.Write("x2 = ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

double userDistance = Distance(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate);
Console.WriteLine($"Расстояние между точками : {userDistance}");