//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да


   int x, x_tmp, x2 = 0;
        Console.Write("Введите число: ");
        string s = Console.ReadLine();
        
        if (int.TryParse(s, out x))
        {
            if (s[0]=='0')Console.WriteLine("не натуральное число");
            else
            {
                x_tmp = x;
                while (x_tmp > 0)
                {
                    x2 *= 10;
                    x2 += x_tmp % 10;
                    x_tmp /= 10;
                }
                if (x == x2) Console.WriteLine("палиндром");
                else Console.WriteLine("не палиндром");
            }
        }
        else
        {
            Console.WriteLine("Введено не число");
        }