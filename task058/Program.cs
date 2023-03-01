// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int m = 2;
int n = 2;
int p = 2;
int [,] mass1 = GenerateArray(m, n, 1, 9);
PrintArray(m, n, mass1);
int [,] mass2 = GenerateArray(n, p, 1, 9);
PrintArray(m, n, mass2);
int [,] mass = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < p; k++)
    {
        int s = 0;
        for (int j = 0; j < n; j++)
        {
            s = s + mass1[i,j] * mass2[j,k];
        }
        mass[i,k] = s;
    }
}
PrintArray(m, n, mass);     
        