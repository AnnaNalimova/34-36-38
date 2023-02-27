// Задайте одномерный массив заполненный случайными числами.
// Найтите сумму элементов стоящих на нечетных индексах.
int[] GetRandomArray( int size, int minValue, int maxValue)
{
    int[]arr = new int[size];
    for (int i=0;i<size; i++)
    {
        arr[i]=new Random().Next(minValue,maxValue);
    }     
    return arr;  
}

int GetSumOddEl(int[] mass)
{
    int sum =0;
    int count= mass.Length;
   for(int i=0;i<count;i++)
   {
     if(i%2!=0) sum= sum+mass[i];
   }
   return sum;
}

int[] massive = GetRandomArray(5,1,10);
int sum = GetSumOddEl(massive);
Console.WriteLine($"[{String.Join(", " ,massive)} ]-> {sum}");

















