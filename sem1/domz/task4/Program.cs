//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число с:");
int c = int.Parse(Console.ReadLine());
int max;
if(a>b && a>c) {
 max = a; 
} else if (b>a && b>c){
 max = b;
} else {
    max = c;
}
Console.WriteLine($"Максимальное число {max}");
