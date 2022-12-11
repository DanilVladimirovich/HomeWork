int ReadInt()
{
    Console.WriteLine("Введите число: ");

    if (int.TryParse(Console.ReadLine(), out int i)) 
    {
        return i;
    }

    Console.WriteLine("Это не число ");

    return -1;
}
int n = ReadInt();
int result = 0;
while (n > 0)
{
    result = result + n % 10; 
    n = n / 10;
    Console.WriteLine(result);
}
Console.WriteLine(result);

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12