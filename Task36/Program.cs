//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int [] arr = GetArray(4);
int res = Sum(arr);
PrintArray(arr);
Console.WriteLine(res);

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

int Sum (int[]arr)
{
    int res =0;
    for (int i=0; i<arr.Length; i++)
    {
        if(i%2==1)
        {
            res+=arr[i];
        }
    }
    return res;
}