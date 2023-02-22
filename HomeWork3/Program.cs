/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет; 12821 -> да; 23432 -> да*/

/*Console.WriteLine("Задача 19");
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
Console.WriteLine();*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine("Задача 21");
void TakeCoords(string A)
{
    Console.WriteLine($"Введите координаты точки {A}");
}
double TakeCor(string N)
    {
        double _X;
        Console.Write($"Введите {N}: ");
        double.TryParse(Console.ReadLine()!, out _X);
        return _X;
    }

TakeCoords("A");
double[] massA = new double[3];
massA[0] = TakeCor("X");
massA[1] = TakeCor("Y");
massA[2] = TakeCor("Z");

TakeCoords("B");
double[] massB = new double[3];
massB[0] = TakeCor("X");
massB[1] = TakeCor("Y");
massB[2] = TakeCor("Z");

double Distance = Math.Sqrt(Math.Pow(massB[0]-massA[0], 2) + Math.Pow(massB[1]-massA[1], 2) + Math.Pow(massB[2]-massA[2], 2)); //квадрат числа
Console.Write("Расстояние между точками A и B в 3D пространстве: ");
Console.WriteLine(Math.Round(Distance, 2)); //округляет до двух знаков после запятой
Console.WriteLine();

//Math.Pow(Distance, (double)1 / 3); //извлечение корня 3ей степени, если не уточнить тип перед 1/3, то 1/3 будет делиться как int, соответственно степень будет неверной

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125*/
/*Console.WriteLine("Задача 23");

int num;
Console.Write($"Введите число: ");
while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Ошибка ввода! Введите число: ");
}

for (int i = 1; i <= num; i++)
{
    Console.Write($"{i*i*i} ");    
}*/