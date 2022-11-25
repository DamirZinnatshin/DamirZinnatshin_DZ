// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// Не используя Math.Pow

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число А");
// string str1 = Console.ReadLine();
// Console.WriteLine("Введите число B");
// string str2 = Console.ReadLine();
// int A = int.Parse(str1);
// int B = int.Parse(str2);
// int i = 2;
// int result = A;
// while (i<=B)
// {
//     result = result*A;
//     i++;
// }
// Console.WriteLine(result);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// string str = Console.ReadLine();
// Console.WriteLine();
// int A = int.Parse(str);
// int sum = 0;
// while ( A > 0)
// {
//     sum = sum + A % 10;
//     A = A / 10;
// }
// Console.WriteLine("Сумма цифр в введённом числе равна " + sum);



// Задача 29: Напишите программу, которая генерирует массив из 8 элементов - случайных чисел (от 0 до 20) 
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 3 -> [1, 2, 5, 7, 19, 6, 1, 3]

// int[] array = new int [8];
// int length = array.Length;
// int i = 0;
// while (i < length)
// {
//     array[i] = new Random().Next(0,21);
//     Console.Write(array[i] + " ");
//     i++;
// }