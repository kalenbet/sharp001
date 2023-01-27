// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 2;
if (b == 0) {Console.WriteLine("да");}
else {Console.WriteLine("нет");}

