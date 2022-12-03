Console.Write("Введите первое число: ");         
int a = int.Parse (Console.ReadLine());
Console.Write("Введите второе число ");
int b = int.Parse (Console.ReadLine());
if (a>b)
    {
        Console.Write ( "Это число больше: " );
        Console.WriteLine ( a );
        Console.Write ( "Это число Меньше: " );
        Console.WriteLine ( b );
    }
    else
    {
        Console.Write ( "Это число больше: " );
        Console.WriteLine ( b );
        Console.Write ( "Это число больше: " );
        Console.WriteLine ( a );
    }



//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3