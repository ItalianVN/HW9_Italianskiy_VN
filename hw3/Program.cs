﻿/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29   */


// функция Аккермана
int GetAccerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return GetAccerman(n - 1, 1);
    else
      return GetAccerman(n - 1, GetAccerman(n, m - 1));
}

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Функция Аккермана А({M},{N}) = {GetAccerman(M, N)}");