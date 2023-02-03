// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int InputNumber(string str)
{
        Console.WriteLine("Введите координату "+ str);
        return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Ax");
int y1 = InputNumber("Ay");
int z1 = InputNumber("Az");
int x2 = InputNumber("Bx");
int y2 = InputNumber("By");
int z2 = InputNumber("Bz");
string a = string.Format("{0:f2}", Math.Pow((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1),(1 / 2.0)));
Console.WriteLine(a);