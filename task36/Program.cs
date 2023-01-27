// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SummaNechet ()
{
int[] arr = new int [6];
int count = 0;
Console.Write("[");
for (int i = 0; i < 6; i++)
{
    arr[i] = new Random().Next(-20, 20);
    Console.Write(arr[i] + ", ");
    if (i % 2 == 1) count = count + arr[i];
}
Console.Write("\b\b] -> ");
return count;
}
Console.Write(SummaNechet());