//dz sem 8:


//zad 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// Console.Clear();
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine());

// NaturalNumbersList(N, 1);
// void NaturalNumbersList(int start, int end)
// {
//     Console.Write($"{start} ");
//     if (start == end)
//         return;
//     NaturalNumbersList(start - 1, end);
// }

//zad 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Clear();

// Console.Write("Введите начало промежутка: ");
// int N = int.Parse(Console.ReadLine());

// Console.Write("Введите конец промежутка: ");
// int M = int.Parse(Console.ReadLine());

// if (N > M)
// {
//     Console.WriteLine("ERROR!");
// }
// else
// {
//     Console.Write(SumNumbers(N, M));
//     SumNumbers(N, M);

//     int SumNumbers(int start, int end)
//     {
//         int sum = 0;
//         if (start == end + 1)
//         {
//             return 0;
//         }
//         sum = start + SumNumbers(start + 1, end);
//         return sum;
//     }
// }
//zad 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.функция
// ack(n, m)
// если n = 0
// вернуть m + 1
// иначе, если m = 0
// вернуть ack (n - 1, 1)
// еще
// вернуть ack(n - 1, ack (n, m - 1))

// Console.Clear();

// Console.Write("Введите начало промежутка: ");
// int N = int.Parse(Console.ReadLine());

// Console.Write("Введите конец промежутка: ");
// int M = int.Parse(Console.ReadLine());

// Console.Write(Ackerman(N, M));

// int Ackerman(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else if ((n != 0) && (m == 0))
//         return Ackerman(n - 1, 1);
//     else
//         return Ackerman(n - 1, Ackerman(n, m - 1));
// }
