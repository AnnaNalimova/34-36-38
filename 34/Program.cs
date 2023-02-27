// Задайте массив заполненный случайными положительными  трехзначными числами.
//Напишите программу , которая покажет колличество четных чисел в массиве.
int[] GetRandomArray( int size, int minValue, int maxValue)
{
    int[]arr = new int[size];
    for (int i=0;i<size; i++)
    {
        arr[i]=new Random().Next(minValue,maxValue);
    }     
    return arr;  
}
int FindEvenNambers(int[] array)
{ 
    int count=0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]%2==0)
        count++;
    }
    return count;
}
int[]massive=GetRandomArray(7,100,1000);
int count=FindEvenNambers(massive);
Console.WriteLine($"[{String.Join(", " ,massive)} ]->{count}");
