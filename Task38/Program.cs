//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int [] arr = GetArray(6);
PrintArray(arr);
int res = MinMax(arr);
Console.WriteLine($"разница: {res}");

int[] GetArray(int length) 
{
    int[] result = new int[length];
    for (int i=0; i< length; i++)
   {
        result[i] = new Random().Next(0,100);
   } 
    return result;
}

void PrintArray(int[]arr)
{
    foreach (int item in arr)
    {
        System.Console.Write(item + ", ");
    }
    System.Console.WriteLine();
}

int MinMax (int[] arr)
{
    int min = arr[0];
    int max = arr[0];

    for(int i=0; i< arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    System.Console.WriteLine("min: " + min);
    System.Console.WriteLine("max: " + max);
    return  max-min;
}
