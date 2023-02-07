// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] a = new int[8];
for (int i = 0; i < 8; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("[");
for (int i = 0; i < 8; i++)
{
    Console.Write(a[i]);
    if (i != 7)
    {
        Console.Write(", ");
    }
}
Console.Write("]");