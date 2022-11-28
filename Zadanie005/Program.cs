// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int [4];
// int length = array.Length;
// for (int i =0; i < length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// int count = 0;
// for (int i =0; i < length; i++)
// {
//     if (array[i]%2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine("Количество чётных чисел в массиве: " + count);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] array = new int [4];
// int length = array.Length;
// for (int i =0; i < length; i++)
// {
//     array[i] = new Random().Next(-99,100);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// int sum1 = 0;
// int sum2 = 0;
// for (int i = 0; i < length; i++)
// {
//     if (i%2 == 0)
//     {
//         sum1 = sum1 + array[i];
//     }
//     else
//     {
//         sum2 = sum2 + array[i];
//     }
// }
// Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum1);
// Console.WriteLine("Сумма элементов, стоящих на чётных позициях: " + sum2);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] array = new double [5];
// int length = array.Length;
// for (int i = 0; i < length; i++)
// {
//     array[i] = new Random().Next(0,100);
//     Console.Write (array[i] + " ");
// }
// Console.WriteLine();
// double max = array[0];
// double min = array[1];
// for (int i = 0; i < length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     if (array[i] < min)
//     {
//         min = array[i];
//     }
// }
// double result = max - min;
// Console.WriteLine("Разница между максимальным и минимальным значением элементов массива: " + result);



// Дополнительно. Задания 3, 4 необязательные
// Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int [] array = new int [8];
// int length = array.Length;
// for (int i = 0; i < length; i++)
// {
//     array[i] = new Random().Next(0,10);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// int find = 4;
// int check = 0;
// for (int j = 0; j < length; j++)
// {
//     if (array[j] == find)
//     {   check = check + find;
//         Console.WriteLine("В данном массиве есть число " + find);
//         break;
//     }
// }
// for (int k = 0; k < length; k++)
// if (check == 0)
// {
//     Console.WriteLine("В данном массиве нет числа " + find);
//     break;
// }




// Задача 4: Задайте массив из 12 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 12
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int [] array = new int [12];
// int length = array.Length;
// for (int i=0; i < length; i++)
// {
//     array[i] = new Random().Next(0,300);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// int count = 0;
// for (int i=0; i < length; i++)
// {
//     if (array[i] > 9 && array[i] < 100)
//     {
//         count = count + 1;
//     }
// }
// Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [10,99] равно " + count);