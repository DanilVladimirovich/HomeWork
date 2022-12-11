double GetNumber(string message) 
{ 
    Console.WriteLine(message); 
    double number = double.Parse(Console.ReadLine()!); 
    return number; 
}
double ax = GetNumber("Введите x1 "); 
double ay = GetNumber("Введите y1 ");
double az = GetNumber("Введите z1 ");
double bx = GetNumber("Введите x2 "); 
double by = GetNumber("Введите y2 ");
double bz = GetNumber("Введите z2 ");

double ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));

Console.WriteLine(ab);

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B(2, 1, -7), -> 15.84
//A(7, -5, 0); B(1, -1, 9)-> 11.53
