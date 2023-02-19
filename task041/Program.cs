// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int InputNumber(int n)
{
        Console.WriteLine("Введите чмсло номер "+ n);
        return Convert.ToInt32(Console.ReadLine());
}

int m = 5;
int s = 0;
for (int i = 1; i <= m; i++)
{
    if (InputNumber(i) > 0){s++;}
}
Console.WriteLine(s);
