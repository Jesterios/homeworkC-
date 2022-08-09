// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a = 2, b = 3, c =7;
int max = 7;
if (a > max ) max = a;
if (b> max ) max = b;
if (c > max ) max = c;
Console.Write("max = ");
Console.WriteLine(max);

int d = 44, e = 5, f = 78;
max = 78;
if (d > max ) max = d;
if (e> max ) max = e;
if (f > max ) max = f;
Console.Write("max = ");
Console.WriteLine(max);

int number1 = 22, number2 = 3, number3 = 9;
max = 22;
if (number1 > max ) max = number1;
if (number2 > max ) max = number2;
if (number3 > max ) max = number3;
Console.Write("max = ");
Console.WriteLine(max);