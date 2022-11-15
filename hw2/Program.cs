/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30   */

int GetSumm(int M, int N)
{
    if (M == N)
    {
        return N;
    }
    return M + GetSumm(M + 1, N);
}

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел между {M} и {N} равна: {GetSumm(M, N)}");
