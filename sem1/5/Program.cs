//На входе трехзначное на выходе последняя цифра
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
number = number % 10;
 Console.WriteLine($"{number}");