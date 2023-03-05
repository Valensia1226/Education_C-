//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

int[] arraySize = TakeNumbersFromConsole("Задайте количество столбцов и строк в массиве через пробел или запятую: ");

int min = TakeNumber("Задайте диапазон случайных вещественных чисел:\nmin = ");
int max = TakeNumber("max = ");

//Создаем массив вещественных чисел по заданным выше параметрам
double[,] array = FillArrayDouble(arraySize[0], arraySize[1], min, max, 0);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[] position = TakeNumbersFromConsole("Введите позицию элемента (строка,столбец): ");
bool flag = false;

for (int i = 0; i < array.GetLength(0); i++) //GetLength(0) возвращает количество строк в массиве
{
    for (int j = 0; j < array.GetLength(1); j++) //GetLength(1) возвращает количество столбцов в массиве
    {
        if (j == position[1] - 1)
            if (i == position[0] - 1)
            {
                Console.WriteLine($"Элемент массива с позицией [{position[0]},{position[1]}] = {array[i, j]}");
                flag = true;
                break;
            }
    }
}
if (flag == false) Console.WriteLine($"Элемента массива с позицией [{position[0]},{position[1]}] не существует");
Console.WriteLine();

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] matrix = FillArrayInteger(3, 4, 0, 10);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

double sum = 0;

for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum = sum + matrix[j, i];
    }
    double average = sum / matrix.GetLength(0);
    Console.WriteLine($"Среднее арифметическое {i}-го столбца = {Math.Round(average, 1)}");
    sum = 0;
}

//Функции
//Создать массив вещественных чисел и заполнить его случайными значениями
double[,] FillArrayDouble(int m, int n, int min, int max, int _round)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength(0) возвращает количество строк в массиве
    {
        for (int j = 0; j < arr.GetLength(1); j++) //GetLength(1) возвращает количество столбцов в массиве
        {
            arr[i, j] = new Random().Next(min, max) + new Random().NextDouble();
            arr[i, j] = Math.Round(arr[i, j], _round);
        }
    }
    return arr;
}

//Вывести массив любого типа на консоль
void PrintArray(Array matr)
{
    switch (matr.Rank)
    {
        case 1:
            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < matr.GetLength(0); i++)
                Console.Write($"{matr.GetValue(i)} ");
            break;
        case 2:
            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr.GetValue(i, j)} ");
                }
                Console.WriteLine();
            }
            break;
    }

}

//Взять целое число с консоли
int TakeNumber(string text)
{
    Console.Write(text);
    int number;
    int.TryParse(Console.ReadLine()!, out number);
    return number;
}

//Взять несколько чисел с консоли, записать в одномерный массив
int[] TakeNumbersFromConsole(string text)
{
    Console.Write(text);
    int[] array = Console.ReadLine()!.Split(' ', ',', '.').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();
    return array;
}

//Создать массив целых чисел и заполнить его случайными значениями
int[,] FillArrayInteger(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength(0) возвращает количество строк в массиве
    {
        for (int j = 0; j < arr.GetLength(1); j++) //GetLength(1) возвращает количество столбцов в массиве
            arr[i, j] = new Random().Next(min, max);
    }
    return arr;
}