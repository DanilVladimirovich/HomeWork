int[,] TwoDementionArray(int lenght, int secondlenght)
{
    Random random = new Random();
    int[,] array = new int[lenght, secondlenght];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1,100);

        }
    }
    return array;
}

    int ReadInt()
    {
        Console.WriteLine("Input number");
        int a = int.Parse(Console.ReadLine());
        return a;
    }

    void GetArrayAsString(int[,] massive)
    {
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                Console.Write($"{massive[i, j]} ");
            }
            Console.WriteLine();
        }
    }

void SerchMass(int[,] massive)
{
    int find = ReadInt();
    int number = 0;
    bool f = false;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (massive[i, j] == find)
            {
                number = massive[i, j]; 
                f = true;
            }         
        }
    }
    if (f)
    {
        Console.WriteLine($"{find} такое число в массиве есть");
    }
    else Console.WriteLine($"{find} - Такого числа в массиве нет");
}

int[,] mass = TwoDementionArray(ReadInt(), ReadInt());
GetArrayAsString(mass);
SerchMass(mass);



//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17->такого числа в массиве нет

//for (int i = 0; i < massive.GetLength(0); i++)
//{
//    for (int j = 0; j < massive.GetLength(1); j++)
//    {
//        if (massive[i, j] == a)
//        {
//            a = massive[i, j];
//            f = true;
//        }
//        if (f == true) Console.WriteLine($"{a} - nfrjt xbckj");
//        else Console.WriteLine("Такого числа нет");

//    }

//}