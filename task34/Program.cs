// Задайте массив, заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве
// [345, 897, 568, 234] -> 2

 
 int Array()
 {
    Console.Write("[");
    int[] arr = new int [10];
    int count = 0;
    for (int i = 0; i < 10; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        if (arr[i] % 2 == 0) count ++;
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b] -> ");
    return count;
 }
 Console.Write(Array());