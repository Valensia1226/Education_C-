/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет; 12821 -> да; 23432 -> да*/

Console.WriteLine("Задача 19");
int Digits(int _a) //количество символов в числе
{
    int count = 0;
    while(_a != 0)
    {
        _a /= 10;
        count ++;
    }
    return count;
}

int number;
Console.Write($"Введите пятизначное число: ");
    while (!int.TryParse(Console.ReadLine(), out number)) //проверка на ввод числа, а не буквы
    {
        Console.WriteLine("Ошибка ввода! Введите пятизначное число: ");
    }

int length = Digits(number);
if (length != 5) //проверка на количество символов в числе
{
    Console.WriteLine("Ошибка ввода! Введите пятизначное число: ");
    int.TryParse(Console.ReadLine()!, out number);
}

char[] c = number.ToString().ToCharArray();
int[]mass = new int[c.Length];

for (int i = 0; i < mass.Length; i++)
            mass[i] = c[i] - '0';

if (mass[0] == mass[4])
{
    if (mass[1]==mass[3])
        if (mass[2]==mass[2]) Console.WriteLine("Является палиндромом");
}
else Console.WriteLine("Не является палиндромом");
Console.WriteLine();

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine("Задача 21");
void TakeCoords(string A)
{
    Console.WriteLine($"Введите координаты точки {A}");
}
int TakeCor(string N)
    {
        int _X;
        Console.Write($"Введите {N}: ");
        int.TryParse(Console.ReadLine()!, out _X);
        return _X;
    }

TakeCoords("A");
int xA = TakeCor("X");
int yA = TakeCor("Y");
int zA = TakeCor("Z");

TakeCoords("B");
int xB = TakeCor("X");
int yB = TakeCor("Y");
int zB = TakeCor("Z");

double Distance = Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));
Console.WriteLine(Math.Round(Distance, 2));
Console.WriteLine();

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125*/
Console.WriteLine("Задача 23");

int num;
Console.Write($"Введите число: ");
while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Ошибка ввода! Введите число: ");
}

for (int i = 1; i <= num; i++)
{
    Console.Write($"{i*i*i} ");    
}