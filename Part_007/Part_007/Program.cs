Console.Write("Введите число равное дню недели: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7)
    Console.WriteLine($"{day} Выходной");
else if (day == 5 || day == 4 || day == 3 || day == 2 || day == 1)
    Console.WriteLine($"{day} Рабочий день");
else Console.WriteLine("Erorr");


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
