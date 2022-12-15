using System.Security.Cryptography.X509Certificates;
float ReadInt(string name)
{
    Console.WriteLine("Введите число: ");
    Console.Write($"{name} = ");
 string s = Console.ReadLine();
    if (float.TryParse(s, out float i))
        return i;
    return -1;
}
string FindPoint(float k1, float k2, float b1, float b2)
{
    float x = 0;
    float y = 0;
    string result = string.Empty;
    if (k1==k2 && b1==b2)
    {
        result = "Отрезки совпадают";
    }
    else if (k1==b1 && k2==b2)
    {
        result = "Отрезки паралельны";
    }
    else 
    {
        x = -(b2 - b1) / (k2 - k1);
        y = k1 * x + b1;
    result = $"Точка пересечения: y = {y} x = {x}";
}
    return result;
}
void Task1()
{
    float k1 = ReadInt("k1");
    float b1 = ReadInt("b1");
    float k2 = ReadInt("k2");
    float b2 = ReadInt("b2");
    Console.WriteLine(FindPoint(k1, k2, b1, b2));
}
Task1();



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)