using System.Security.Cryptography.X509Certificates;

float ReadInt()
{
    Console.WriteLine("Введите число: ");
 string s = Console.ReadLine();
    if (float.TryParse(s, out float i))
        return i;
    return -1;
}

Console.Write("k1 = ");
float k1 = ReadInt();
Console.Write("d1 = ");
float b1 = ReadInt();
Console.Write("k2 = ");
float k2 = ReadInt();
Console.Write("d2 = ");
float b2 = ReadInt();
    float x = 0;
    float y = 0; 
    if (k1==k2 && b1==b2)
    {
        Console.WriteLine("Отрезки совпадают");
    }
    else if (k1==b1 && k2==b2)
    {
        Console.WriteLine("Отрезки паралельны");
    }
    else 
    {
        x = -(b2 - b1) / (k2 - k1);
        y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения: y = {y} x = {x}");
}
    
 




//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)