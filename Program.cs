//Dz sem 6:

// // Zad 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Clear();

// Console.Write("Введите сколько чисел хотите ввести: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] UserArray = new int[M];
// for (int i = 0; i < M; i++)
// {
//     Console.Write($"Введите {i + 1} число: ");
//     UserArray[i] = Convert.ToInt32(Console.ReadLine());
// }

// int CountPositiveNumbers(int[] Array)
// {
//     int j = 0;
//     foreach (int i in Array)
//     {
//         if (i > 0)
//         {
//             j += 1;
//         }
//     }
//     return j;
// }

// void ShowArray(int[] Arr)
// {
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write(Arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// ShowArray(UserArray);
// Console.WriteLine($"Введено чисел > 0: {CountPositiveNumbers(UserArray)}");

// // Zad 2:  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// //         y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.Clear();

// Console.Write("Введите значение b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите значение k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите значение b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите значение k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());

// if (b1 == b2 && k1 == k2)
// {
//     Console.WriteLine("Прямые лежат друг на друге");
// }
// else if (b1 == b2 || k1 == k2)
// {
//     Console.WriteLine("Прямые параллельны");
// }
// else
// {
//     double[] CrossPoint(double ArrB1, double ArrK1, double ArrB2, double ArrK2)
//     {
//         double[] result = new double[2];
//         result[0] = (ArrB2 - ArrB1) / (ArrK1 - ArrK2);
//         result[1] = ArrK1 * result[0] + ArrB1;
//         return result;
//     }

//     void ShowArray(double[] Arr)
//     {
//         for (int i = 0; i < Arr.Length; i++)
//         {
//             Console.Write(Arr[i] + " ");
//         }
//         Console.WriteLine();
//     }

//     ShowArray(CrossPoint(b1, k1, b2, k2));
// }
