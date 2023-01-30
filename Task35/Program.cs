//Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].

int[] CreateArrayRndInd(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] massive)
{
    Console.Write("[");
    for (int i = 0; i < massive.Length; i++)
    {
        if (i < massive.Length - 1) Console.Write($"{massive[i]}, ");
        else Console.Write($"{massive[i]}");
    }
    Console.Write("]");
}

int ElementsCount(int[] massive, int min, int max)
{
    int result = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] >= min && massive[i] <= max)
        result++;
    }
    return result;
}

int[] arr = CreateArrayRndInd(10, -200, 200);
PrintArray(arr);
int answer = ElementsCount(arr, 10, 99);
Console.WriteLine();
Console.WriteLine($"Количество искомых элементов -> {answer}");