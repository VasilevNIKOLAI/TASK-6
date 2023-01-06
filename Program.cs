// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// int size;
// Console.WriteLine("Введите количество чисел М: ");
// int.TryParse(Console.ReadLine()!, out size);

// int[] n = new int[size];
// FillArray(n); 
// PrintArray(n);
// int count = 0;

// for (int i = 0; i < n.Length; i++)
// if (n[i] > 0)
// count++;

// Console.WriteLine($"В массиве {n.Length} чисел, чисел больше нуля: {count}");

// void FillArray(int[] _n)
// {
//     for(int i = 0; i < _n.Length; i++)
//     {
//         int a;
//         Console.Write($"Введите элемент[{i}]: ");
//         int.TryParse(Console.ReadLine()!, out a);
//         _n[i] = a;
//     }
// }
// void PrintArray(int[] _n)
// {
//     for(int i = 0; i < _n.Length; i++)
//     {
//         Console.Write(_n[i] + " ");
//     }
//     Console.WriteLine();
// }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int b1, b2, k1, k2;
b1 = 2;
k1 = 5;
b2 = 4;
k2 = 9;
double x = (double)(b2 - b1) / (k1 - k2);
double y = (double)k1 * x + b1;
Console.Write($"({x};{y})");