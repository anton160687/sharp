// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.Write("Введите координату x точки A: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y точки A: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату z точки A: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату x точки В: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y точки В: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату z точки В: ");
double z2 = double.Parse(Console.ReadLine());
double x21 = x2-x1;
double y21 = y2-y1;
double z21 = z2-z1;
double d = Math.Sqrt(x21*x21+y21*y21+z21*z21);
Console.WriteLine($"{d}");