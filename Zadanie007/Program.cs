// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами от -10,0 до 10,0.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

// void FillMatrixDouble(double[,] matrix)
// {
//     for (int m = 0; m < matrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < matrix.GetLength(1); n++)
//         {
//             double number = new Random().Next(-10, 11) + new Random().NextDouble();
//             matrix[m, n] = Math.Round(number, 2);
//         }
//     }
// }
// void PrintMatrixDouble(double[,] matrix)
// {
//     for (int m = 0; m < matrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < matrix.GetLength(1); n++)
//         {
//             Console.Write($"{matrix[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// double[,] matrix = new double[3, 4];
// FillMatrixDouble(matrix);
// Console.WriteLine();
// PrintMatrixDouble(matrix);


// Задача 50. Напишите программу, которая на вход принимает число, и возвращает 
// индексы числа в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void FillMatrixInt(int[,] matrix)
// {
//     for (int m = 0; m < matrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < matrix.GetLength(1); n++)
//         {
//             matrix[m, n] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintMatrixInt(int[,] matrix)
// {
//     for (int m = 0; m < matrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < matrix.GetLength(1); n++)
//         {
//             Console.Write($"{matrix[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] matrix = new int[3, 4];
// FillMatrixInt(matrix);
// Console.WriteLine();
// PrintMatrixInt(matrix);
// Console.WriteLine("Введите число, индексы которого нужно найти в массиве:");
// string str = Console.ReadLine();
// int find = int.Parse(str);
// int check = 0;
// for (int m = 0; m < matrix.GetLength(0); m++)
// {
//     for (int n = 0; n < matrix.GetLength(1); n++)
//     {
//         if(matrix [m,n] == find)
//         {
//             Console.WriteLine("Индексы заданного числа в массиве: " + m + " , " + n);
//             check = 1;
//         }
//     }
// }
// if(check == 0)
// {
//     Console.WriteLine("Данного числа в массиве нет");
// }




// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void FillMatrixInt(double[,] matrix)
// {
//     for (int m = 0; m < matrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < matrix.GetLength(1); n++)
//         {
//             matrix[m, n] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintMatrixInt(double[,] matrix)
// {
//     for (int m = 0; m < matrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < matrix.GetLength(1); n++)
//         {
//             Console.Write($"{matrix[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// double[,] matrix = new double[3, 4];
// FillMatrixInt(matrix);
// Console.WriteLine();
// PrintMatrixInt(matrix);
// Console.WriteLine();
// Console.Write("Среднее арифметическое каждого столбца массива: ");
// double numbers = 0;
// double sumNumbers = 0;
// for (int n = 0; n < matrix.GetLength(1); n++)
// {
//     for (int m = 0; m < matrix.GetLength(0); m++)
//     {
//         numbers = numbers + matrix[m,n] / matrix.GetLength(0);
//         sumNumbers = Math.Round(numbers,1);
//     }
//     Console.Write(sumNumbers + "; ");
//     numbers = 0;
//     sumNumbers = 0;
// }



        

