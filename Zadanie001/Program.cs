// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число");
// string str1 = Console.ReadLine();
// Console.WriteLine("Введите второе число");
// string str2 = Console.ReadLine();
// int A = int.Parse(str1);
// int B = int.Parse(str2);
// if (A > B)
// {
//     Console.WriteLine(A + " - большее число");
//     Console.WriteLine(B + " - меньшее число");
// }
// else
// {
//     Console.WriteLine(B + " - большее число");
//     Console.WriteLine(A + " - меньшее число");
// }



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

// Console.WriteLine("Введите первое число");
// string str1 = Console.ReadLine();
// Console.WriteLine("Введите второе число");
// string str2 = Console.ReadLine();
// Console.WriteLine("Введите третье число");
// string str3 = Console.ReadLine();
// int A = int.Parse(str1);
// int B = int.Parse(str2);
// int C = int.Parse(str3);
// if (A > B && A > C)
// {
//     Console.WriteLine(A + " является максимальным из трёх чисел");
// }
// if (B > A && B > C)
// {
//     Console.WriteLine(B + " является максимальным из трёх чисел");
// }
// if (C > A && C > B)
// {
//     Console.WriteLine(C + " является максимальным из трёх чисел");
// }




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// string str = Console.ReadLine();
// int A = int.Parse(str);
// if (A % 2 == 0)
// {
//     Console.WriteLine(A + " является чётным числом (делится на два без остатка)");
// }
// else
// {
//     Console.WriteLine(A + " НЕ является чётным числом (НЕ делится на два без остатка)");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число больше единицы");
// string str = Console.ReadLine();
// Console.WriteLine();
// int N = int.Parse(str);
// int A = 1;
// while (A <= N)
// {
//     if (A % 2 == 0)
//     {
//         Console.WriteLine(A);
//     }
//     A++;
// }
