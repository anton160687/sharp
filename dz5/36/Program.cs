// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.Clear();
int[] startArray = GetArray(4, 2 , 10);
Console.WriteLine($"-> {GetCountElements(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]}, ");
    }
    return res;
}

int GetCountElements(int[] array)
{
int summa = 0;
    for (int i = 0; i < array.Length; i++)
{
    
    if (i % 2 != 0){
        summa += array[i];
        }
       
}
    

  
    return summa;
}