//24 Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A
// a = 5
// sum = 1 + 2 + 3 + 4 + 5
// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int GetNum(int number){
    int count = 0;
    if(number<0) {
       number *= (-1);
    }
    while(number > 0){
        number /= 10;
        count++;
    }
    return count;
}
Console.WriteLine(GetNum(number));
