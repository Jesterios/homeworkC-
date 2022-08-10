//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.Write("Введите число:   ");
int value = Convert.ToInt32(Console.ReadLine());

int a = value % 1000;
int b = a / 100;

if(b > 0)
{
    Console.WriteLine(b);
}
else    {

    Console.WriteLine("-");
}
