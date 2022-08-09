//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a = 5, b = 7;
max = 7;
min = 5;
if(a > max) max = a;
if(b > max) max = b;
Console.Write("max = ");
Console.WriteLine(max);
if(a < min) min = a;
if(b < min) min = b;
Console.Write("min = ");
Console.WriteLine(min);

int c = 2, d = 10;
max = 10;
min = 2;
if(c > max) max = c;
if(d > max) max = d;
Console.Write("max = ");
Console.WriteLine(max);
if(c < min) min = c;
if(d < min) min = d;
Console.Write("min = ");
Console.WriteLine(min);

int e = -9, f = -3;
max = -3;
min = -9;
if(e > max) max = e;
if(f > max) max = f;
Console.Write("max = ");
Console.WriteLine(max);
if(e < min) min = e;
if(f < min) min = f;
Console.Write("min = ");
Console.WriteLine(min);

