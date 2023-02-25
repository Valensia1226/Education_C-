//Задать массив из 12 эл-ов, случайные числа [-9, 9]. Найти сумму отрицательных и положительных элементов массива.

/*int[] array = FillArray(12, -9, 10);

Console.Write($"{String.Join(", ", array)}\n"); //берет все элементы массива, преобразует их в строку и разбивает все элементы запятой
//фактически заменяет собой прописанный нами метод Print

Print(array);

int pos = 0;
int neg = 0;

foreach(int el in array) //работает быстрее for, так как не пересчитывает каждый раз размер массива, а просто проходится по всем элементам от нулевого до последнего, 
                        //в таком цикле нельзя изменить значение элемента
{
    pos += el > 0 ? el : 0; //тернарный оператор: условие, вопрос, значение при верном условии, двоеточие, значение при неверном условии
    neg += el < 0 ? el : 0;
    //или
    int temp = el > 0 ? pos += el : neg += el;
    //или
    if (el > 0)
        pos += el;
    else
        neg += el;
}

 for(int i=0; i < array.Length; i++)
 {
    if (array[i] > 0)
        pos += array[i];
    else
        neg += array[i];
 }

Console.Write($"pos sum = {pos} \nneg sum = {neg}");*/


int[] FillArray(int size, int min=0, int max=10)
{
    int[] arr = new int[size];
    for(int i=0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}

void Print(Array arr)
{
    for(int i=0; i < arr.Length; i++)
        Console.Write($"{arr.GetValue(i)} ");
    Console.WriteLine();
}

//Меняем элементы массива на противоположные по знаку
/*int a = 5;
a = ChangeA(a);
Console.Write(a);

int[] array = FillArray(12, -9, 10);
Console.Write($"{String.Join(", ", array)}\n");
Console.Write($"{String.Join(", ", InverseElements(array))}\n");

int ChangeA(int _a)
{
    _a *= -1;
    return _a;
}

int[] InverseElements(int[] arr) //будет работать и в виде void так как для изменения массива не нужно его переприсваивать, функция сработает и без return
{
    for (int i=0; i < arr.Length; i++)
        arr[i] *= -1;
    return arr;
}*/

//Произведение пар в массиве (первый элемент на последний, второй на предпоследний и т.д.)
int[] array = FillArray(5, 0, 10);
int[] pairs = new int[array.Length / 2 + array.Length % 2];

Console.Write($"{String.Join(", ", array)}\n");
MultiplyPairs(array, pairs);
Console.Write($"{String.Join(", ", pairs)}\n");


void MultiplyPairs(int[] arr, int[] pair)
{
    int size = arr.Length;
    int pairSize = arr.Length / 2 + arr.Length % 2;

    for (int i=0; i < size/2; i++)
    {
        int rev = size - i - 1;
        pair[i] = arr[i] * arr[rev];
    }
    if (size % 2 != 0)
        pair[pairSize -1] = arr[pairSize];
}