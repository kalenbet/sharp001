// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
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
int isCh = 0;
int[] mass = GenerateArray(n, 100, 999);
Console.Write("[");
for (int i = 0; i < n; i++)
{
    Console.Write(mass[i]);
    if (mass[i] % 2 == 0)
    {
        isCh += 1;
    }
    if (i != n - 1)
    {
        Console.Write(", ");
    }
}
Console.Write("] -> ");
Console.Write(isCh);