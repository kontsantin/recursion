///Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


// int Natural(int a, int b) {
//     if(a > b) return 0;
//     Console.Write(a + " ");
//     return Natural(a+1, b);
// }

// Natural(-6, 5);

// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// using System;

// class Program
// {
//     static void Main()
//     {
  
//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine());

  
//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine());

 
//         int result = Ackermann(m, n);


//         Console.WriteLine($"A({m}, {n}) = {result}");
//     }


//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (m > 0 && n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else 
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }
// }


// ///Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// // int[] array = {1, 2, 3, 4, 5};
// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задание произвольного массива
//         int[] array = { 1, 2, 3, 4, 5 };

//         // Вывод элементов массива в обратном порядке
//         PrintArrayReverse(array, array.Length - 1);
//     }

//     // Рекурсивная функция для вывода элементов массива в обратном порядке
//     static void PrintArrayReverse(int[] array, int index)
//     {
//         if (index < 0)
//         {
//             return;
//         }

//         Console.Write($"{array[index]} ");
//         PrintArrayReverse(array, index - 1);
//     }
// }