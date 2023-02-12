// DZ sem 7:

// zad 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] Array = RandomArray(rows, columns, 0, 100);
// PrintArray(Array);

// double[,] RandomArray(int m, int n, int start, int end)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble() * (start - end);
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]:f3} ");
//         }
//         Console.WriteLine();
//     }
// }

// zad 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение элемента: ");
// int element = Convert.ToInt32(Console.ReadLine());

// int[,] Array = RandomArray(rows, columns, 0, 100);
// PrintArray(Array);

// if (ElementSearch(Array, element))
// {
//     Console.WriteLine("Элемент найден");
// }
// else
// {
//     Console.WriteLine("Элемент не найден");
// }

// int[,] RandomArray(int m, int n, int start, int end)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(start, end + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// bool ElementSearch(int[,] Array, int el)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             if (Array[i, j] == el)
//             {
//                 return true;
//             }
//         }
//     }
//     return false;
// }
// zad 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] Array = RandomArray(rows, columns, 0, 100);
// PrintArray(Array);

// double[] MiddleSum = ResultArray(Array);
// Console.WriteLine($"Среднее Арифметическое столбцов = {String.Join("; ", MiddleSum)}");

// int[,] RandomArray(int m, int n, int start, int end)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(start, end + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// double[] ResultArray(int[,] Array)
// {
//     double[] result = new double[Array.GetLength(1)];
//     for (int i = 0; i < Array.GetLength(1); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < Array.GetLength(0); j++)
//         {
//             sum += Array[j, i];
//         }
//         result[i] = Math.Round(sum / Array.GetLength(0), 2);
//     }
//     return result;
// }
