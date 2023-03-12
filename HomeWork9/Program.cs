//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int K = 8;

Console.Write($"Все натуральные числа от N до 1, где N = {K} -> ");
ReturnAllNatural(K);
 
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = 1, N = 15;
int sum = 0;

for (int i = M; i <= N; i++)
    sum += i;

Console.WriteLine($"Сумма натуральных элеменов в промежутке от M до N, где M = {M}, N = {N} -> {sum}");

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = 3, n = 2;
Console.WriteLine($"Результат вычисления функции Аккермана для m = {m}, n = {n} -> {AkkermanFunction(m, n)}");

//Функции
//Возвращает натуральные числа от 1 до а
void ReturnAllNatural(int a)
{
    Console.Write($"{a} ");
    a = a - 1;
    if (a > 0)
        ReturnAllNatural(a);
}

//Функция Аккермана
int AkkermanFunction(int m, int n)
{
    int rezult = 0;
    if (m < 0 || n < 0) Console.WriteLine("Функция Аккермана применима только для неотрицательных чисел");
    else
    {
        if (m == 0) rezult = n + 1;
        if (m > 0 && n == 0) rezult = AkkermanFunction(m - 1, 1);
        if (m > 0 && n > 0) rezult = AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
    return rezult;
}
