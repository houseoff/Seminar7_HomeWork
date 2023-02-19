// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

double[,] NewArray ()
{
    double[,] array = new double[new Random().Next(2, 6), new Random().Next(2, 6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = Math.Round(10 * new Random().NextDouble(), 2);
    }
    return array;
}

void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} \t");
        Console.WriteLine();
    }
}

void CheckIndex (double[,] array, int x, int y)
{
    if (x >= array.GetLength(0) | y >= array.GetLength(1))
        Console.WriteLine($"Индекс [{x},{y}] находится вне границ массива");
    else
        Console.WriteLine($"Элемент с индексом [{x},{y}] равен {array[x, y]}");
}

Console.Clear();
Console.Write($"Введите индекс элемента массива: ");
int[] size = Console.ReadLine()!.Split(',').Select(x => int.Parse(x)).ToArray();
Console.WriteLine("Исходный массив");
double[,] array = NewArray();
PrintArray(array);
CheckIndex(array, size[0], size[1]);