double[,] TwoDementionArray(int lenght, int secondlenght)
{
   Random random = new Random(); 
	double[,] array = new double[lenght,secondlenght];
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
            array[i,j] = random.NextDouble() * 100;
            
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

void GetArrayAsString(double[,] massive)
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

double[,] massiv = TwoDementionArray(ReadInt(), ReadInt());
Console.WriteLine();
GetArrayAsString(massiv);

//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9