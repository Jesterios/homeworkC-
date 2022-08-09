// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

if(n == -3)
{
    Console.WriteLine("Нет");
}

if(n == -2)
{
    Console.WriteLine("да");
}

if(n == -1)
{
    Console.WriteLine("Нет");
}


if(n == 1)
{
    Console.WriteLine("Нет");
}

if(n == 2)
{
    Console.WriteLine("да");
}

if(n == 3)
{
    Console.WriteLine("Нет");
}

if(n == 4)
{
    Console.WriteLine("да");
}

if(n == 5)
{
    Console.WriteLine("Нет");
}

if(n == 6)
{
    Console.WriteLine("да");
}

if(n == 7)
{
    Console.WriteLine("Нет");
}
