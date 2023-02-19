// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
int[] startArray = GetArray(4, 100 , 999);
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
    int count = 0;
    foreach (var item in array)
    {
       int items = item % 2;
        if (items == 0) count++;
    }
    return count;
}
