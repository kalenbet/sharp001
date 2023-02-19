// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
float InputNumber(string n)
{
        Console.WriteLine("Введите параметр "+ n);
        return Convert.ToInt32(Console.ReadLine());
}

float FindX(float k1, float k2, float b1, float b2)
{
    return (b2 - b1) / (k1 - k2);
}

float FindY(float k1, float b1, float x)
{
    return k1 * x + b1;
}

float k1 = InputNumber("k1");
float k2 = InputNumber("k2");
float b1 = InputNumber("b1");
float b2 = InputNumber("b2");

float x = FindX(k1, k2, b1, b2);
float y = FindY(k1, b1, x);
string a = string.Format("{0:f1}", x);
string b = string.Format("{0:f1}", y);
Console.WriteLine($"({a};{b})");

