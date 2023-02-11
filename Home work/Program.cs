//Задача 2: 
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

void SayMax(int max)
{
    Console.WriteLine("Максимальное число = " + max);
}

Console.WriteLine("Задача 2");

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) SayMax(a);
else SayMax(b);

//Задача 4
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Задача 4");

Console.WriteLine("Введите первое число");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int e = Convert.ToInt32(Console.ReadLine());

int Max = c;
if (d > Max) Max = d;
if (e > Max) Max = e;

SayMax(Max);

//Задача 6
//4 -> да, -3 -> нет, 7 -> нет
Console.WriteLine("Задача 6");

Console.WriteLine("Введите число для проверки четности");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.WriteLine(num + " " + "является четным");
else Console.WriteLine(num + " " + "является нечетным");

//Задача 8
//5 -> 2, 4; 8 -> 2, 4, 6, 8
Console.WriteLine("Задача 8");

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа от 1 до введенного вами: ");
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0) Console.Write(i + " ");
}