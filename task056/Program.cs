// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int mins = 1000000;
int mini = 0;
for (int i = 0; i < m; i++)
{   
    int s = 0;
    for (int j = 0; j < n; j++)
    {
        s = s + mass[i,j];
    }
    if (s < mins)
    {
        mins = s;
        mini = i + 1;
    }

}
Console.WriteLine(mini);