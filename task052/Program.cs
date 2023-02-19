// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
for (int i = 0; i < n; i++)
{
    int s = 0;
    for (int j = 0; j < m; j++)
    {
        s = s + mass[j,i];
    }
    float sa = (float)s / m;
    string st = string.Format("{0:f2}", sa);
    Console.WriteLine("столбец: " + (i+1) + "; среднее арифметическое: " + st);
}