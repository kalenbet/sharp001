// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (a < 100) {Console.Write("третьей цифры нет");}
else 
    {
        int c = a / 100 % 10;
        Console.Write(c);
    }