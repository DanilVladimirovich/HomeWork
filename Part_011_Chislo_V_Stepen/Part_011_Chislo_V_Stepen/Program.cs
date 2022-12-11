int ReadInt()
{
    Console.Write("Введите число: ");

    if (int.TryParse(Console.ReadLine(), out int i)) // 6, number
    {
        return i;
    }

    Console.WriteLine("It's not a number");

    return -1;
}
int ReadIntTwo()
{
    Console.Write("Введите Степень: ");

    if (int.TryParse(Console.ReadLine(), out int i)) // 6, number
    {
        return i;
    }

    Console.WriteLine("It's not a number");

    return -1;
}

double number = ReadInt();
double degree = ReadIntTwo();
double result = 0;
result = Math.Pow(number, degree);
Console.WriteLine($"Число: {number} в степени {degree} = {result}");


//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4-> 16