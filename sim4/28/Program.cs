//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int GetNum(int n){  
     int result = 1;   
    for(int i = 2; i<=n; i++ ){
               
        result  *= i;
    }
    return result;
}
Console.WriteLine(GetNum(number));
