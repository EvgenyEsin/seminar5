// Задайте массив целых чисел. Найдите разницу между максимальным
// и минимальным элементом массива.
// [3 7 22 2 78] -> 76

int MaxMin ()
{
int index = new Random().Next(4, 9);
int[] arr = new int [index];
int max = 0;
int min = 19;
Console.Write("[");
for (int i = 0; i < index; i++)
{
    arr[i] = new Random().Next(-20, 20);
    Console.Write(arr[i] + " ");
    if (arr[i] > max) max = arr[i];
    else if (arr[i] < min) min = arr[i];
}
Console.Write("] -> ");
return max - min;
}
Console.Write(MaxMin());