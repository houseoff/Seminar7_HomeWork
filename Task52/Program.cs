// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] NewArray ()
{
    int[,] array = new int[new Random().Next(2, 6), new Random().Next(2, 6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0, 11);
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} \t");
        Console.WriteLine();
    }
}

void ArithmeticMean (int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            sum += array[j, i];
        Console.WriteLine($"Среднее ариметическое столбца с индексом {i}: {sum}");
        sum = 0;
    }                         
}

Console.Clear();
Console.WriteLine("Исходный массив");
int[,] array = NewArray();
PrintArray(array);
ArithmeticMean(array);