// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// Console.Clear();
// int[] array = new int[];
// int[] Array(int[] array);
// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int number3 = int.Parse(Console.ReadLine());
if(number+number2>number3 || number2+number3>number || number+number3>number2) {
    Console.WriteLine("Нет");
} else {
    Console.WriteLine("Да");
}