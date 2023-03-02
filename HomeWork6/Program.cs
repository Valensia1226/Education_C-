//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа: ");
int[] array = Console.ReadLine()!.Split(' ', ',', '.').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();
int sum = 0;

foreach (int el in array)
    if (el > 0) sum++;

Console.WriteLine($"Количество элементов больше нуля = {sum}");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] equation1 = TakeConstant(1);
int[] equation2 = TakeConstant(2);

//Метод Крамера
double mainDeterminant = equation2[0] - equation1[0];
double determinantX = equation1[1] - equation2[1];
double determinantY = equation2[0] * equation1[1] - equation1[0] * equation2[1];
double x = determinantX / mainDeterminant;
double y = determinantY / mainDeterminant;

Console.WriteLine($"Точка пересечения двух прямых, заданных уравнениями y = {equation1[0]}*x + {equation1[1]} и y = {equation2[0]}*x + {equation2[1]} -> ({Math.Round(x, 1)}; {Math.Round(y, 1)})");

int[] TakeConstant(int equationNumber)
{
    Console.Write($"Введите переменные k и b {equationNumber}-го уравнения соответственно: ");
    int[] array = Console.ReadLine()!.Split(' ', ',', '.').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();
    return array;
}
