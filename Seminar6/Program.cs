//Программа, которая перевернет одномерный массив

/*int[] array = FillArray(5);
Print(array);

for(int i=0; i < array.Length/2; i++)
{
    int rev=array.Length - i - 1;
    (array[i], array[rev]) = (array[rev], array[i]); //меняем местами
}

Print(array);*/

/* int[] array = new int[3];
string[] str_nums = Console.ReadLine()!.Split(' ', ',', '.');
 */
//или

int[] array = Console.ReadLine()!.Split(' ', ',', '.').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();

/* for (int i = 0; i < 3; i++)
    array[i] = int.Parse(str_nums[i]); */

if (array[0] + array[1] > array[2] && array[1] + array[2] > array[0] && array[0] + array[2] > array[1])
    Console.Write($"Треугольник существует ");
else Console.Write($"Треугольник не существует ");


int[] FillArray(int size, int min = 0, int max = 9)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max + 1);
    return arr;
}

void Print(Array arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr.GetValue(i)} ");
    Console.WriteLine();
}