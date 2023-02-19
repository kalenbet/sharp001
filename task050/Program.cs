// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] GenerateArray(int m, int n, int min, int max)
{
    int [,] arr = new int[m,n];
    Random a = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = a.Next(min, max + 1);
        }
    }
    return arr;
}

int m = 4;
int n = 5;
int [,] mass = GenerateArray(m, n, 0, 20);
Console.WriteLine("Введите номер позиции от 1 до " + (m*n));
int p = Convert.ToInt32(Console.ReadLine());
if (p > m*n)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine(mass[(p - 1) / n, (p - 1) % n]);
}