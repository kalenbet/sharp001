// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= a; i++)
{ 
    int b = i % 2;
    if (b == 0) 
    {
        if (i != 2) {Console.Write(", ");}
        Console.Write(i);
    }
}
