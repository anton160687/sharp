// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> среда
Console.Write("Введите номер недели: ");
int day = int.Parse(Console.ReadLine());
if (day<1 || day>7) {
    Console.WriteLine("Введите число в диапозоне от 1 до 7");
}
if (day == 1)
{
    Console.WriteLine("понедельник");
}
if (day == 2)
{
    Console.WriteLine("вторник");
}
if (day == 3)
{
    Console.WriteLine("среда");
}
if (day == 4)
{
    Console.WriteLine("четверг");
}
if (day == 5)
{
    Console.WriteLine("пятница");
}

