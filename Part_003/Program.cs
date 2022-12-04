Console.Write("Введитое число: ");
int i = int.Parse (Console.ReadLine());
if (i % 2 == 0)
{
    Console.Write("Четное: ");
    Console.WriteLine(i);
}
else
{
    Console.Write("Нe четное: ");
    Console.WriteLine(i);
}


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
