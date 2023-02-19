//Семинар 2
void WriteArray(int[] col)
{
    int length = col.Length;
    int index = 0;
    int i = 1;
    while (index < length)
    {
        Console.WriteLine("Введите " + i + " цифру вашего числа");
        col[index] = int.Parse(Console.ReadLine()!);
        index++;
        i++;
    }
}

void PrintArray(int[] Coll)
{
    int count = Coll.Length;
    int position = 0;
    Console.Write("Ваше число: ");
    while (position < count)
    {
        Console.Write(Coll[position]);
        position++;
    }
}

//Задача 10. Трехзначное число на вход, на выходе показывает вторую цифру этого числа
//456 -> 5, 782 -> 8, 918 -> 1

int[] array = new int[3];
WriteArray(array);
Console.Write("Вторая цифра вашего числа: " + array[1]);

// Второй вариант решения
/*int number;
Console.Write("Введите трехзначное число: ");
int.TryParse(Console.ReadLine()!, out number);
Console.Write(number / 10 % 10);*/

//Задача 13. Выводит третью цифру задачнного числа или сообщает, что ее нет
//645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

int number;
Console.WriteLine("Сколько цифр в вашем числе?");
int.TryParse(Console.ReadLine()!, out number);

int[] mass = new int[number];
WriteArray(mass);
PrintArray(mass);
int len = mass.Length;
if (len < 3) Console.WriteLine("\n Третьей цифры нет");
else Console.WriteLine("\n" + "Третья цифра вашего числа: " + mass[2]);

//второй вариант решения
/*int[] array = {3, 2, 6, 7, 9};
int length = array.Length;
if (length > 2) Console.WriteLine(array[2]);
else Console.WriteLine("Третьей цифры нет");*/

//Задача 15. Принимает на вход цифру, обозначающую день недели, проверяет, является ли этот день выходным
int num;
Console.Write("Введите число от 1 до 7: ");
int.TryParse(Console.ReadLine()!, out num);
if (num < 1 || num > 7) 
{
    Console.WriteLine("Ошибка!");
    Console.Write("Введите число от 1 до 7: ");
    int.TryParse(Console.ReadLine()!, out num);
}
if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5) Console.WriteLine ("Не является выходным");
if (num == 6 || num == 7) Console.WriteLine ("Является выходным");