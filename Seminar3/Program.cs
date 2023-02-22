// Задача 1. На входе координаты точки (X и Y), не равные нулю, на выходе номер четверти плоскости, в которой находится эта точка.

/*int x, y;
Console.Write($"Введите x: ");
int.TryParse(Console.ReadLine()!, out x);
Console.Write($"Введите y: ");
int.TryParse(Console.ReadLine()!, out y);

    if (x > 0)
    {
        if (y > 0) Console.WriteLine("Точка находится в 1 четверти");
        else Console.WriteLine("Точка находится в 4 четверти");
    }
    else
    {
        if (y > 0) Console.WriteLine("Точка находится в 2 четверти");
        else Console.WriteLine("Точка находится в 3 четверти");
    }*/

// Задача 2. На входе номер четверти, на выходе диапазон возможных координат (X и Y) точек в этой четверти
int n;
Console.Write("Введите номер плоскости: ");
int.TryParse(Console.ReadLine()!, out n);

/*if (n == 1)
    Console.Write($"X > 0, Y > 0");
else if (n == 2)
    Console.Write($"X < 0, Y > 0");
else if (n == 3)
    Console.Write($"X < 0, Y < 0");
else if (n == 4)
    Console.Write($"X > 0, Y < 0");*/
    
switch(n) //switch работает быстрее, чем if, в case нельзя использовать переменные, которые меняются (только константы)
{
    case 1: 
        Console.Write($"X > 0, Y > 0");
        break;
    case 6:
    case 2: //выполнит дальнейшее при вариантах 6 или 2
        Console.Write($"X < 0, Y > 0");
        break;
    case 3: 
        Console.Write($"X < 0, Y < 0");
        break;
    case 4: 
        Console.Write($"X > 0, Y < 0");
        break;
    default:
        Console.Write($"Неверно введен номер плоскости");
        break;
}

switch("Hello") //также можно работать со строками
{
    case "Hi":
        Console.Write("Hello");
        break;
    case "Hello":
        Console.Write("Hi");
        break;
}

