// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());int Revers(int num){
    int revers = 0;// 54321
    while (num > 0)
        { // num = 0 > 0                        54320
            revers = revers * 10 + num % 10; // revers = 5432 * 10 + num%10(1%10 = 1) = 54321
            num /= 10; // num / 10(1/10)
        }// 12345 == 54321
    return revers;
}
if (num == Revers(num))
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}