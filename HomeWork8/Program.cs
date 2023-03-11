//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine($"Задача 54. Задан двумерный массив:\n");
int[,] array = FillArrayInteger(4, 4, 0, 10);
PrintArray(array);
SortToMin(array);

//Сортировка элементов по убыванию в каждой строке двумерного массива
void SortToMin(int[,] array)
{
    Console.WriteLine($"Результат после сортировки по убыванию в строках массива:");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int[] line = TransformToOnedimensionalArray(array, i);
        SelectionSort(line);
        PrintArray(line);
    }
}

//Преобразование выбранной строки двумерного массива в одномерный массив
int[] TransformToOnedimensionalArray(int[,] array, int i)
{
    int[] arr = new int[array.GetLength(0)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        arr[j] = array[i, j];
    }
    return arr;
}

//Сортировка от большего к меньшему
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine();
Console.WriteLine($"Задача 56. Задан прямоугольный массив:\n");
int[,] arr = FillArrayInteger(4, 5, 0, 10);
PrintArray(arr);
SearchLineWithMinSum(arr);

//Суммирование элементов в строке
int SumInLine(int[,] array, int i)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    return sum;
}

//Поиск строки с наименьшей суммой элементов
void SearchLineWithMinSum(int[,] array)
{
    int lineWithMinSum = SumInLine(array, 0);
    Console.WriteLine($"Сумма элементов в 1 строке = {lineWithMinSum}");
    int indexLineWithMinSum = 0;

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumLine = SumInLine(array, i);
        if (i == 1) Console.WriteLine($"Сумма элементов во {i + 1} строке = {sumLine}");
        else Console.WriteLine($"Сумма элементов в {i + 1} строке = {sumLine}");

        if (sumLine < lineWithMinSum)
        {
            lineWithMinSum = sumLine;
            indexLineWithMinSum = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Индекс строки с наименьшей суммой элементов = {indexLineWithMinSum}");
}

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine();
Console.WriteLine($"Задача 58. Заданы две матрицы:\n");
int[,] matrix1 = FillArrayInteger(2, 2, 0, 10);
PrintArray(matrix1);
int[,] matrix2 = FillArrayInteger(2, 2, 0, 10);
PrintArray(matrix2);

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] rezult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < rezult.GetLength(0); i++)
    {
        for (int j = 0; j < rezult.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
               sum = sum + matrix1[i, k] * matrix2[k, j];
            }
            rezult[i, j] = sum;
            sum = 0;
        }
    }
    Console.WriteLine("Результат перемножения матриц:\n");
    PrintArray(rezult);
}
else Console.WriteLine("Умножение матриц невозможно. Требуется, чтобы число столбцов первой матрицы равнялось числу строк второй матрицы!");

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] threeDimentionArray = new int[2, 2, 2];

for (int i = 0; i < threeDimentionArray.GetLength(0); i++)
{
    for (int j = 0; j < threeDimentionArray.GetLength(1); j++)
    {
        for (int k = 0; k < threeDimentionArray.GetLength(2); k++)
        {
            threeDimentionArray[i, j, k] = new Random().Next(10, 101);
            
            Console.Write($"{threeDimentionArray[i, j, k]} ({i}, {j}, {k}) ");
        }
        Console.WriteLine();
    }
} 

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] spiral = new int[4, 4];
for (int i = 0; i < spiral.GetLength(0); i++)
{
    for (int j = 0; j < spiral.GetLength(1); j++)
    {
        if (i == 0) spiral[i, j] = j + 1;
        if (j == 3 && (i == 1 || i == 2)) spiral[i, j] = 4  + i;
        
        if (i == 3) spiral[i, j] = 10 - j;
        if (i == 1 && j != 3) spiral[i, j] = 12 + j;
        if (i == 2)
        {
            if (j == 0) spiral[i, j] = 11;
            else if (j == 1) spiral[i, j] = 16;
            else if (j == 2) spiral[i, j] = 15;
        }
    }
}
for (int i = 0; i < spiral.GetLength(0); i++)
{
    for (int j = 0; j < spiral.GetLength(1); j++)
    {
        if (spiral[i, j] / 10 == 0) Console.Write($"0{spiral.GetValue(i, j)} ");
        else Console.Write($"{spiral.GetValue(i, j)} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

//Общие Функции
//Вывести массив любого типа на консоль
void PrintArray(Array matr)
{
    switch (matr.Rank)
    {
        case 1:
            for (int i = 0; i < matr.GetLength(0); i++)
                Console.Write($"{matr.GetValue(i)} ");
            Console.WriteLine();
            break;
        case 2:
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr.GetValue(i, j)} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            break;
        case 3:
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    for (int k = 0; k < matr.GetLength(2); k++)
                    {
                        Console.Write($"{matr.GetValue(i, j, k)} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            break;
    }

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