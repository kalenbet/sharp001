// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("1");
for (int i = 2; i <= a; i++)
    { 
        Console.Write(", ");
        Console.Write(Math.Pow(i, 3));
    }
