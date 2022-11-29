// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double xa = Convert.ToInt32(Console.ReadLine());
double ya = Convert.ToInt32(Console.ReadLine());
double za = Convert.ToInt32(Console.ReadLine());
double xb = Convert.ToInt32(Console.ReadLine());
double yb = Convert.ToInt32(Console.ReadLine());
double zb = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
Console.WriteLine(result);