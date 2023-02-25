//Задать массив из 12 эл-ов, случайные числа [-9, 9]. Найти сумму отрицательных и положительных элементов массива.

int[] array = FillArray(12, -9, 10);

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
    //Console.Write(el); //обращается к элементу
    /*if (el > 0)
        pos += el;
    else
        neg += el;*/
}

 /*for(int i=0; i < array.Length; i++)
 {
    if (array[i] > 0)
        pos += array[i];
    else
        neg += array[i];
 }*/

Console.Write($"pos sum = {pos} \nneg sum = {neg}");


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

//