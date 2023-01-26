//На входе трехзначное на выходе последняя цифра
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if(number<100 || number > 999){
    Console.WriteLine("Ошибка");
    return;
}
number = number % 10;
 Console.WriteLine($"{number}");