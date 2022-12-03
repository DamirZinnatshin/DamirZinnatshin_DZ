// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите первое число");
// string str1 = Console.ReadLine();
// int A1 = int.Parse(str1);
// Console.WriteLine("Введите второе число");
// string str2 = Console.ReadLine();
// int A2 = int.Parse(str2);
// Console.WriteLine("Введите третье число");
// string str3 = Console.ReadLine();
// int A3 = int.Parse(str3);
// Console.WriteLine("Введите четвёртое число");
// string str4 = Console.ReadLine();
// int A4 = int.Parse(str4);
// Console.WriteLine("Введите пятое число");
// string str5 = Console.ReadLine();
// int A5 = int.Parse(str5);
// int[] array = {A1,A2,A3,A4,A5};
// int length = array.Length;
// int result = 0;
// for (int i = 0; i < length; i++)
// {
//     if (array[i] > 0)
//     {
//         result++;
//     }
// }
// Console.WriteLine("Количество положительных чисел, введённых пользователем: " + result);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Введите первое число");
// string str1 = Console.ReadLine();
// double b1 = double.Parse(str1);
// Console.WriteLine("Введите второе число");
// string str2 = Console.ReadLine();
// double k1 = double.Parse(str2);
// Console.WriteLine("Введите третье число");
// string str3 = Console.ReadLine();
// double b2 = double.Parse(str3);
// Console.WriteLine("Введите четвёртое число");
// string str4 = Console.ReadLine();
// double k2 = double.Parse(str4);
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;
// Console.WriteLine($"Точка пересечения двух прямых имеет координаты ({x};{y})");
