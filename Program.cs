// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// __________________________________________
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// void printNumbers(int N)
// {
//     Console.WriteLine(N);
//     if (N == 1)
//     {
//         return;
//     }
//     else
//     {
//         printNumbers(N-1);
//     }
// }

// printNumbers(5);



// ________________________________________
// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

//  Console.WriteLine("Введите m");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(Console.ReadLine());

// int sm = 0;

// for (int i = m; i <= n; i++)
// {
//       sm += i;
// }
// Console.WriteLine(sm);

// _________________________________________
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// A(0,m)=m+1
// A(n+1,0) = A(n,1)
// A(n+1,m+1) = A(n,A(n+1,m))

// int A(int n, int m)
// {
//     if (n == 0)
//     {
//         return m+1;
//     }
//     else
//     {
//         if ((n != 0) && (m == 0))
//         {
//             return A(n-1,1);
//         }
//         else
//         {
//             return A(n-1,A(n,m-1));
//         }
//     } 
// }
// Console.WriteLine(A(3,2));
