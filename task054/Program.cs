// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void PrintArray(int m, int n, int [,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = 4;
int n = 5;
int [,] mass = GenerateArray(m, n, 1, 9);
PrintArray(m, n, mass);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n-1; j++)
    {
        for (int k = 0; k < n-1-j; k++)
        {
            if (mass[i,k] < mass[i,k+1]) 
            {
                int s = mass[i,k];
                mass[i,k] = mass[i,k+1];
                mass[i,k+1] = s;
            }
        }
    }
}
PrintArray(m, n, mass);