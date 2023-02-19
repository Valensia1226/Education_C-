/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵); 2, 4 -> 16*/

Console.WriteLine("Задача 25");
int str;
int TakeInt(string _str = "число")
{
    Console.Write($"Введите {_str}: ");
    while (!int.TryParse(Console.ReadLine(), out str)) //проверка на ввод числа, а не буквы
    {
        Console.WriteLine($"Ошибка ввода! Введите {_str}: ");
    }
    return str;
}

int A = TakeInt();
string s = "степень";
int B = TakeInt(s);
int result = A;

for (int i = 1; i < B; i++)
{
    result = result*A;
}
Console.WriteLine($"{A}^{B} = {result}");

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11; 82 -> 10; 9012 -> 12*/

Console.WriteLine("Задача 27");
int TakeLast(int a)
{
    int b = a % 10;
    return b;
}

int number = TakeInt();
int num = number;
int sum = 0;
while (number > 0)
{
    sum = sum + TakeLast(number);
    number = number / 10;
}

Console.WriteLine($"{num} -> {sum}");

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] ; 6, 1, 33 -> [6, 1, 33]*/

int[] array = new int[8];
