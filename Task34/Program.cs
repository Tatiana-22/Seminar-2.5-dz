//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int [] arr = GetArray(4);
int res = CountArray(arr);
PrintArray(arr);
Console.WriteLine(res);

int[] GetArray(int length)
{
    int[] result = new int[length];
    for (int i=0; i< length; i++)
   {
        result[i] = new Random().Next(100,1000);
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

int CountArray(int[]arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if(item % 2 == 0)
        {
            count++;
        }
 
    }
    return count;
}