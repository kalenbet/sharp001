//  Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

float [,] GenerateArray(int m, int n, double min, double max)
{
    float [,] arr = new float[m,n];
    Random rand = new Random();
    double range = max - min;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double sample = rand.NextDouble();
            double scaled = (sample * range) + min;
            arr[i,j] = (float)scaled;
        }
    }
    return arr;
}

void PrintArray(int m, int n, float [,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            string s = string.Format("{0:f2}", arr[i,j]);
            Console.Write(s + " ");
        }
        Console.WriteLine();
    }
}

float [,] a = GenerateArray(3, 4, -10, 10);
PrintArray(3, 4, a);
