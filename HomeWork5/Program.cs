//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int size = WriteCol();

int[] array = FillArray(size, 100, 1000);
Print(array);
int Col = 0;

foreach(int el in array)
    if (el % 2 == 0) Col++;

Console.WriteLine($"Количество четных чисел в массиве = {Col}");
Console.WriteLine();

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

int size2 = WriteCol();
int[] mass = FillArray(size2, -100, 100);
Print(mass);
int Sum = 0;

for (int i = 1; i < mass.Length; i++)
    if (i % 2 != 0) Sum = Sum + mass[i];

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве = {Sum}");
Console.WriteLine();

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int size3 = WriteCol();
Console.WriteLine("До скольки округлить?");
int round;
int.TryParse(Console.ReadLine(), out round);

double[] arr = FillArrayDouble(size3, 0, 100, round);
Print(arr);

SelectionSort(arr);
Print(arr);
double rez = arr[arr.Length - 1] - arr[0];

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(rez, round)}");
Console.WriteLine();

//Функции
int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for(int i=0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}

double[] FillArrayDouble(int size, int min, int max, int _round)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max) + new Random().NextDouble();
        arr[i] = Math.Round(arr[i], _round);
    }
    return arr;
}

void Print(Array arr)
{
    for(int i=0; i < arr.Length; i++)
        Console.Write($"{arr.GetValue(i)} ");
    Console.WriteLine();
}

int WriteCol()
{
    Console.WriteLine("Сколько чисел в массиве?");
    int _size;
    int.TryParse(Console.ReadLine(), out _size);
    return _size;
}

void SelectionSort(double[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        double temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;        
    }
}
