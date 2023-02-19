// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);

Console.WriteLine(String.Join(" ", ResultArray(baseArray)));

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int ResultArray(int[] array)
{
  
  for (int i = 0; i < array.Length; i++){
				for (int j = 0; j < array.Length - 1; j++){
					if (array[j] > array[j + 1])
					{
						int t = array[j + 1];
						array[j + 1] = array[j];
						array[j] = t;
					}
                    
                    }
              
    }
      
     
    int result = 0;
    foreach (var item in array)
    {
        result = array[array.Length-1]-array[0];
    } 

    
    return result;
}
