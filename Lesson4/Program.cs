/* Двумерные массивы
string[,] table = new string[2,3] - таблица строк
int[,] matrix = new int[5, 8] - таблица чисел, 5 строк, 8 столбцов*/

/*string[,] table = new string[2,5];
table[1,2] = "word";

for (int rows=0; rows < 2; rows++)
{
    for (int columns =0; columns < 5; columns++)
    {
        Console.WriteLine($"{table[rows, columns]}-");
    }
}*/

/*int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);*/

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //GetLength(0) возвращает количество строк в массиве
    {
        for (int j = 0; j < matr.GetLength(1); j++) //GetLength(1) возвращает количество столбцов в массиве
        {
            matr[i, j] = new Random().Next(1, 10); //[1,10)
        }
    }
}

//рекурсия - функция, которая вызывает сама себя
//факториал
double Factorial(int n) //для типа int на 17! будет переполнение типа, выдаст отрицательное значение
{
    if (n == 1 || n == 0) return 1;
    else return n * Factorial(n - 1);
}

//Console.WriteLine(Factorial(5));

//Числа Фибоначи
//f(1) = 1, f(2) = 1, f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)
    Console.WriteLine($"f({i}) = {Fibonacci(i)}"); //тупит после i=39
