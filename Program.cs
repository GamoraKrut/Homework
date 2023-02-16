//dz sem 8
//zad 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] Array = RandomArray(rows, columns, 0, 100);

// PrintArray(Array);
// SortArray(Array);
// Console.WriteLine();
// PrintArray(Array);

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

// void SortArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             for (int t = j + 1; t < Array.GetLength(1); t++)
//             {
//                 if (Array[i, t] > Array[i, j])
//                 {
//                     int temp = Array[i, j];
//                     Array[i, j] = Array[i, t];
//                     Array[i, t] = temp;
//                 }
//             }
//         }
//     }
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


//zad 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] Array = RandomArray(rows, columns, 0, 10);

// PrintArray(Array);

// Console.WriteLine($"Строка с наименьшей суммой: {GetRowNumber(Array)}");

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

// int GetRowNumber(int[,] Array)
// {
//     int row = 0;
//     int minsum = 0;
//     for (int i = 0; i < Array.GetLength(1); i++)
//     {
//         minsum = minsum + Array[0, i];
//     }
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             sum = sum + Array[i, j];
//         }
//         if (minsum > sum)
//         {
//             minsum = sum;
//             row = i;
//         }
//     }
//     return row + 1;
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

//zad 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rowsA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columnsA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество строк 2 массива: ");
// int rowsB = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов 2 массива: ");
// int columnsB = Convert.ToInt32(Console.ReadLine());
// if (columnsA != rowsB)
// {
//     Console.WriteLine("ERROR!");
//     return;
// }

// int[,] A = RandomArray(rowsA, columnsA, 0, 10);
// int[,] B = RandomArray(rowsB, columnsB, 0, 10);

// PrintArray(A);
// Console.WriteLine();
// PrintArray(B);
// Console.WriteLine();

// PrintArray(MultiplicationMatrix(A, B));

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

// int[,] MultiplicationMatrix(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int row = 0; row < arrayA.GetLength(0); row++)
//     {
//         for (int column = 0; column < arrayB.GetLength(1); column++)
//         {
//             for (int k = 0; k < arrayA.GetLength(1); k++)
//             {
//                 arrayC[row, column] += arrayA[row, k] * arrayB[k, column];
//             }
//         }
//     }
//     return arrayC;
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

//zad 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


// Console.Clear();

// Console.Write("Введите размеры массива через пробел: ");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(
//     new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) },
//     10,
//     99
// );
// PrintArray(array);

// int[,,] GetArray(int[] sizes, int min, int max)
// {
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < result.GetLength(2))
//             {
//                 int element = new Random().Next(min, max + 1);
//                 if (FindElement(result, element))
//                     continue;
//                 result[i, j, k] = element;
//                 k++;
//             }
//         }
//     }
//     return result;
// }

// bool FindElement(int[,,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == el)
//                     return true;
//             }
//         }
//     }
//     return false;
// }

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

//zad 5: Напишите программу, которая заполнит спирально массив 4 на 4.

// Console.Clear();

// Console.Write("Введите размер матрицы: ");
// int s = int.Parse(Console.ReadLine());
// int[,] arr = GetArray(s);
// PrintArray(arr);

// int[,] GetArray(int size)
// {
//     int[,] result = new int[size, size];
//     int i = 0;
//     int j = 0;
//     int rowE = size - 1;
//     int columnE = size - 1;
//     int rowS = 0;
//     int columnS = 0;
//     bool left = true;
//     bool top = true;
//     int count = 0;
//     while (count < size * size)
//     {
//         count++;
//         result[i, j] = count;
//         if (left && top)
//         {
//             if (j == columnE)
//             {
//                 rowS++;
//                 top = true;
//                 left = false;
//                 i++;
//                 continue;
//             }
//             else
//             {
//                 j++;
//                 continue;
//             }
//         }
//         if (!left && top)
//         {
//             if (i == rowE)
//             {
//                 columnE--;
//                 top = false;
//                 left = false;
//                 j--;
//                 continue;
//             }
//             else
//             {
//                 i++;
//                 continue;
//             }
//         }
//         if (!left && !top)
//         {
//             if (j == columnS)
//             {
//                 rowE--;
//                 top = false;
//                 left = true;
//                 i--;
//                 continue;
//             }
//             else
//             {
//                 j--;
//                 continue;
//             }
//         }
//         if (left && !top)
//         {
//             if (i == rowS)
//             {
//                 columnS++;
//                 top = true;
//                 left = true;
//                 j++;
//                 continue;
//             }
//             else
//             {
//                 i--;
//                 continue;
//             }
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
