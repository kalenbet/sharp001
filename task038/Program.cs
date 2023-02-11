// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
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
int n = 10;
int min = 1000;
int max = -1000;
int[] mass = GenerateArray(n, -99, 99);
Console.Write("[");
for (int i = 0; i < n; i++)
{
    Console.Write(mass[i]);
    if (mass[i] > max)
    {
        max = mass[i];
    }
        if (mass[i] < min)
    {
        min = mass[i];
    }
    if (i != n - 1)
    {
        Console.Write(", ");
    }
}
Console.Write("] -> ");
Console.Write(max - min);