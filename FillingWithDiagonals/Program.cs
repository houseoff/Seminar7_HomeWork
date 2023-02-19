// Заполнение диагоналями
// Гененрируется псевдослучайный массив и заполняется значениями от 0 до array.GetLength(0) * array.GetLength(1) по диагонали

int[,] NewArray()
{
    int[,] array = new int[new Random().Next(3, 6), new Random().Next(8, 11)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0) * array.GetLength(1); i++)
        for (int j = 0; j < array.GetLength(0); j++)
            for (int k = 0; k < array.GetLength(1); k++)
                if (j + k == i)
                {
                    array[j, k] = count;
                    count++;
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

Console.Clear();
Console.WriteLine("Исходный массив");
PrintArray(NewArray());