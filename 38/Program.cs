// Задайте массив целых чисел.Найдите разницу 
//между максимальным и минимальным элементом массива.
int[] GetRandomArray( int size, int minValue, int maxValue)
{
    int[]arr = new int[size];
    for (int i=0;i<size; i++)
    {
        arr[i]=new Random().Next(minValue,maxValue);
    }     
    return arr;  
}
int FindDiff(int[] mass)
{
    int max=mass[0];
    int min=mass[0];
    int diff=0;
    for(int i=0;i<mass.Length;i++)
    {
        if(mass[i]>max) max=mass[i];
        if(mass[i]< min)  min=mass[i];
        diff=max-min;
    }
    return diff;
}
int[] massive=GetRandomArray(7,3,10);
int diff=FindDiff(massive);
Console.WriteLine($"[{String.Join(", " ,massive)} ]-> {diff}");


