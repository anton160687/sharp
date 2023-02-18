// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите число A: ");
int number_A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int number_B = int.Parse(Console.ReadLine());
if (number_A <=0 || number_B <= 0){
    Console.WriteLine("Введите число больше 0");
}
int GetNum(int number_A, int number_B) {
   int j = 1;
    for(int i = 0; i < number_B; i++ ) {
     j *= number_A;
    }
    return j;
}
int result = GetNum(number_A, number_B);
Console.WriteLine($"{result}");