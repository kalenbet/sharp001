﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = 3;
int n = 2;
Console.WriteLine(Akkerman(m,n));