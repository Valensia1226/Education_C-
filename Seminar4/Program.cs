//Семинар 4. Функции.
int str;
int TakeInt(string _str = "Введите число: ")
{
    Console.Write($"Введите число: ");
    int.TryParse(Console.ReadLine()!, out str);
    return str;
}

/*Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out b);*/

/*int d = 2;
int f = 7;
Summ(d, f);
Summ(11, 9);

void Summ(int _a, int _b)
{
    int c = _a + _b;
    Console.WriteLine($"{_a} + {_b} = {c}");
}*/

//На входе число, на выходе сумма от 1 до этого числа.

/*int a = TakeInt();
int sum = 0;
for (int i = 0; i <= a; i++)
    sum +=i;
Console.Write($"{a} -> {sum}");*/

//Принимает на вход число, выдает количество цифр в числе
/*int a = TakeInt();
Console.Write($"{a} -> {Digits(a)}");

int Digits(int _a)
{
    int count = 0;
    while(_a != 0)
    {
        _a /= 10;
        count ++;
    }
    return count;
}*/

//Структуры и классы
struct Point
{
    public double x;
    public double y;
    public double z;
    void TakeCoords()
    {
        string coords = Console.ReadLine()!;
        double[] numbers = coords.Split(' ').Where(x => double.TryParse(x, out _)).Select(double.Pars).ToArray();
        /*List<int> numbers = new List<int>(Array.ConvertAll(coords.Split(' '), int.Parse)); //динамический список, который может увеличивать или уменьшать свой размер в ходе выполнения программы
        //Split разделяет строку, int.Pars переводит в int и записывает в массив*/
        if (numbers.Length != 3)
        {
            x = 0; y = 0; z = 0;
            return;
        }
        x = numbers[0];
        y = numbers[1];
        z = numbers[2];
    }
}