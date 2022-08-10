//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

System.Console.Write("Введите число:   ");
int value = Convert.ToInt32(Console.ReadLine());

int a = value % 100;
int b = a / 10;

if(b > 0)
{
    Console.WriteLine(b);
}
else    {

    Console.WriteLine("-");
}
