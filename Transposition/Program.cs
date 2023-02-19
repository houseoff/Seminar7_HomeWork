// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов матрицы. 
// В каждой из последующих N строк записаны M целых чисел – элементы матрицы. Все числа во входных данных не превышают 100 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали.

// Блок 1. Код для запуска в Visual Studio Code
internal class Program
{
    private static void Main(string[] args)
    {
        void InputArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = new Random().Next(0, 101);
            }
        }

        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write($"{array[i, j]} \t");
                Console.WriteLine();
            }
        }

        int[,] Transpositon(int[,] array)
        {
            int[,] TranspositonArray = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = array.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    TranspositonArray[array.GetLength(0) - 1 - i, j] = array[i, j];
            }
            return TranspositonArray;
        }

        Console.Clear();
        Console.Write($"Введите размер массива: ");
        int[] size = Console.ReadLine()!.Split(',').Select(x => int.Parse(x)).ToArray();
        int[,] array = new int[size[0], size[1]];
        Console.WriteLine("Исходный массив");
        InputArray(array);
        PrintArray(array);
        Console.WriteLine("Транспонированный массив");
        PrintArray(Transpositon(array));
    }
}

// Блок 2. Код для запуска на сайте https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=8&id_topic=120&id_problem=745
// using System;
// using System.IO;

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         void PrintTranspositionArray (int[,] array, StreamWriter swriter)
//         {
//             for (int i = array.GetLength(0) - 1; i >= 0; i--)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                     swriter.Write($"{array[i,j]} ");
//                 swriter.WriteLine();
//             }
//         }

//         StreamReader sr = new StreamReader("input.txt");
//         StreamWriter sw = new StreamWriter("output.txt");

//         string[] SizeArray = sr.ReadLine().Split();
//         int[,] Array = new int[int.Parse(SizeArray[0]), int.Parse(SizeArray[1])];
//         for (int i = 1; i <= Array.GetLength(0); i++)
//         {
//             string[] TempArray = sr.ReadLine().Split();
//             for (int j = 0; j < TempArray.Length; j++)
//             {
//                 Array[i - 1, j] = int.Parse(TempArray[j]);
//             }
//         }

//         PrintTranspositionArray(Array, sw);

//         sr.Close();
//         sw.Close();
//     }
// }


// Блок 3. "Читерский" способ решения на сайте https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=8&id_topic=120&id_problem=745
// using System;
// using System.IO;
 
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         StreamWriter sw = new StreamWriter("output.txt");
 
//         string[] array = File.ReadAllLines("input.txt");
//         for (int i = array.Length - 1; i >=1; i--)
//             sw.WriteLine(array[i]);
 
//         sw.Close();
//     }
// }