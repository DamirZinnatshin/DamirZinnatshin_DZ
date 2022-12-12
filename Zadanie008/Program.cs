// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
// PrintMatrixInt(matrix);
// Console.WriteLine();

// for (int m = 0; m < matrix.GetLength(0); m++)
// {
//     for (int n = 0; n < matrix.GetLength(1); n++)
//     {
//         for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//         {
//             if (matrix[m, k] < matrix[m, k + 1])
//             {
//                 int mean = matrix[m, k + 1];
//                 matrix[m, k + 1] = matrix[m, k];
//                 matrix[m, k] = mean;
//             }
//         }
//     }
// }

// PrintMatrixInt(matrix);
// Console.WriteLine();



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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
// int[,] matrix = new int[4, 4];
// FillMatrixInt(matrix);
// Console.WriteLine();
// PrintMatrixInt(matrix);
// Console.WriteLine();
// int sum0 = 0;
// int sum1 = 0;
// int sum2 = 0;
// int sum3 = 0;
// for (int m = 0; m < matrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < matrix.GetLength(1); n++)
//         {
//             sum0 = sum0 + matrix[m,n];
//         }
//         break;
//     }
// for (int m = 1; m < matrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < matrix.GetLength(1); n++)
//         {
//             sum1 = sum1 + matrix[m,n];
//         }
//         break;
//     }
// for (int m = 2; m < matrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < matrix.GetLength(1); n++)
//         {
//             sum2 = sum2 + matrix[m,n];
//         }
//         break;
//     }
// for (int m = 3; m < matrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < matrix.GetLength(1); n++)
//         {
//             sum3 = sum3 + matrix[m,n];
//         }
//         break;
//     }

// if (sum0 < sum1 && sum0 < sum2 && sum0 < sum3)
// {
//     Console.WriteLine("Строка с наименьшей суммой - 1 строка");
// }
// if (sum1 < sum0 && sum1 < sum2 && sum1 < sum3)
// {
//     Console.WriteLine("Строка с наименьшей суммой - 2 строка");
// }
// if (sum2 < sum0 && sum2 < sum1 && sum2 < sum3)
// {
//     Console.WriteLine("Строка с наименьшей суммой - 3 строка");
// }
// if (sum3 < sum0 && sum3 < sum1 && sum3 < sum2)
// {
//     Console.WriteLine("Строка с наименьшей суммой - 4 строка");
// }



// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, 
// которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:

// 2 4
// 3 2

// 3 4
// 3 3

// Результирующая матрица будет:

// 6 16
// 9 6

// int ReadNumber(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int rows = ReadNumber("Введите количество строк: ");
// int columns = ReadNumber("Введите количество столбцов: ");
// int[,] array1 = new int[rows, columns];
// int[,] array2 = new int[rows, columns];
// int[,] array3 = new int[rows, columns];

// FillMatrix(array1);
// PrintMatrix(array1);

// Console.WriteLine();

// FillMatrix(array2);
// PrintMatrix(array2);

// Console.WriteLine();

// for (int i = 0; i < array1.GetLength(0); i++)
// {
//     for (int j = 0; j < array1.GetLength(1); j++)
//     {
//         array3[i, j] = 0;
//         array3[i, j] = array1[i, j] * array2[i, j];

//     }
// }

// PrintMatrix(array3);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int fill = 10;
// void FillMatrix3D(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = fill;
//                 fill = fill + 5;
//             }
//         }
//     }
// }

// void PrintMatrix3D(int[,,] array)
// {
//     for (int k = 0; k < array.GetLength(0); k++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             for (int j = 0; j < array.GetLength(2); j++)
//             {
//                 Console.Write($"{array[i, j, k]} {(i,j,k)} ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
// int [,,] array = new int [2,2,2];
// FillMatrix3D(array);
// PrintMatrix3D(array);

