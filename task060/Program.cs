// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int [,,] GenerateArray(int l, int m, int n, int min, int max)
{
    int [,,] arr = new int[l,m,n];
    Random a = new Random();
    for (int k = 0; k < l; k++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[k,i,j] = a.Next(min, max + 1);
            }
        }
    }
    return arr;
}

void PrintArray(int l, int m, int n, int [,,] arr)
{
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write(arr[j,k,i] + "(" + j + "," + k + "," + i + ") ");
            }
            Console.WriteLine();
        }    
    }
    Console.WriteLine();
}

int l = 2;
int m = 2;
int n = 2;
int [,,] mass = GenerateArray(l, m, n, 1, 99);
PrintArray(l, m, n, mass);