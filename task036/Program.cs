// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GenerateArray(int len, int minV, int maxV)
{
    int [] arr = new int[len];
    Random a = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = a.Next(minV, maxV + 1);
    }
    return arr;
}
int n = 6;
int sum = 0;
int[] mass = GenerateArray(n, -99, 99);
Console.Write("[");
for (int i = 0; i < n; i++)
{
    Console.Write(mass[i]);
    if (i % 2 == 1)
    {
        sum += mass[i];
    }
    if (i != n - 1)
    {
        Console.Write(", ");
    }
}
Console.Write("] -> ");
Console.Write(sum);