// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
if(a % 2 == 0){
    Console.WriteLine($"Числоv {a} четное");
} else {
    Console.WriteLine($"Числоv {a} не четное");
}

