Console.Write("Введите число для проверки палиндрома: ");
string number = Console.ReadLine();
string numberTwo = string.Empty;
for (int i = number.Length - 1; i >= 0; i--)
{ 
numberTwo+= number[i].ToString();  
}
if (number == numberTwo)
{
    Console.WriteLine($"{number} - Палиндром");
}
else 
{
    Console.WriteLine($"{number} - Не является палиндромом");
}

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да