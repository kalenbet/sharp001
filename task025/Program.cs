// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int p = 1;
for (int i = 1; i <= b; i++)
    { 
        p = p * a;
    }
Console.Write(p);
