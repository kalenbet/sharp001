// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
void PrintArray(int m, int n, string [,] arr)
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


int n = 4;
string [,] mass = new string[n,n];
string way = "r";
int m = n;
int d = 1;
int x = 0;
int y = -1;
while (d <= n*n)
{
    for(int i = 0; i < m; i++)
    {
        if (way == "r") {y++;}
        else if (way == "l") {y--;}
        else if (way == "u") {x--;}
        else if (way == "d") {x++;}
        if (d < 10){mass[x,y]="0" + d.ToString();}
        else{mass[x,y]=d.ToString();}
        d++;
    }
    if (way == "r") {way = "d"; m--;}
    else if (way == "l") {way = "u"; m--;}
    else if (way == "u") {way = "r";}
    else if (way == "d") {way = "l";}
}

PrintArray(n, n, mass);