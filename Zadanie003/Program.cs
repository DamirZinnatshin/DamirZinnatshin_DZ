// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом (т.е. число должно быть одинаковым при чтении слева направо и справа налево).

// 14212 -> нет
// 12821 -> да
// 23432 -> да


// 1-ый вариант
// Console.WriteLine("Введите пятизначное число");
// string str = Console.ReadLine();
// int A0 = str [0];
// int A1 = str [1];
// int A3 = str [3];
// int A4 = str [4];
// if (A0 == A4 && A1 == A3)
// {
//     Console.WriteLine("Число является палиндромом");
// }
// else
// {
//     Console.WriteLine("Число НЕ является палиндромом");
// }

// 2-ой вариант
// Console.WriteLine("Введите пятизначное число");
// string str = Console.ReadLine();
// if (str.Length == 5)
// {
// if (str[0] == str[4] && str[1] == str[3])
// {
//     Console.WriteLine($"{str} - палиндром");
// }
// else
// {
//     Console.WriteLine($"{str} - не палиндром");
// }
// }
// else
// {
//     Console.WriteLine("Ввели не пятизначное число");
// }




// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine ("Введите координату х1");
// string str1 = Console.ReadLine();
// Console.WriteLine ("Введите координату у1");
// string str2 = Console.ReadLine();
// Console.WriteLine ("Введите координату z1");
// string str3 = Console.ReadLine();
// Console.WriteLine ("Введите координату х2");
// string str4 = Console.ReadLine();
// Console.WriteLine ("Введите координату у2");
// string str5 = Console.ReadLine();
// Console.WriteLine ("Введите координату z2");
// string str6 = Console.ReadLine();
// int x1 = int.Parse(str1);
// int y1 = int.Parse(str2);
// int z1 = int.Parse(str3);
// int x2 = int.Parse(str4);
// int y2 = int.Parse(str5);
// int z2 = int.Parse(str6);
// int x = x2-x1;
// int y = y2-y1;
// int z = z2-z1;
// double result = Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2)+Math.Pow(z, 2));
// Console.WriteLine (result);



// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число N");
// string str = Console.ReadLine();
// Console.WriteLine();
// int N = int.Parse(str);
// int i = 1;
// double A =0;
// while (i <= N)
// {
//     A = Math.Pow(i,3);
//     Console.WriteLine(A);
//     i++;
// }