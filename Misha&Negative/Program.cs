// Миша уже научился хорошо фотографировать и недавно увлекся программированием. 
// Первая программа, которую он написал, позволяет формировать негатив бинарного черно-белого изображения.

// Бинарное черно-белое изображение – это прямоугольник, состоящий из пикселей, 
// каждый из которых может быть либо черным, либо белым. 
// Негатив такого изображения получается путем замены каждого черного пикселя на белый, а каждого белого пикселя – на черный.

// Миша, как начинающий программист, написал свою программу с ошибкой, поэтому в результате ее исполнения мог получаться некорректный негатив. 
// Для того чтобы оценить уровень несоответствия получаемого негатива исходному изображению, Миша начал тестировать свою программу.

// В качестве входных данных он использовал исходные изображения. Сформированные программой негативы он начал тщательно анализировать, 
// каждый раз определяя число пикселей негатива, которые получены с ошибкой.

// Требуется написать программу, которая в качестве входных данных использует исходное бинарное черно-белое 
// изображение и полученный Мишиной программой негатив, и на основе этого определяет количество пикселей, в которых допущена ошибка.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит целые числа n и m (1 ≤ n, m ≤ 100) – высоту и ширину исходного изображения (в пикселях). 
// Последующие n строк содержат описание исходного изображения. Каждая строка состоит из m символов «B» и «W». 
// Символ «B» соответствует черному пикселю, а символ «W» – белому. Далее следует пустая строка, 
// а после нее – описание выведенного Мишиной программой изображения в том же формате, что и исходное изображение.

// Выходные данные
// В выходной файл OUTPUT.TXT необходимо вывести число пикселей негатива, которые неправильно сформированы Мишиной программой.

// Блок 1. Код для запуска в Visual Studio Code

internal class Program
{
    private static void Main(string[] args)
    {
        void FillArray(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"Введите {i + 1} строку: ");
                string Temp = Console.ReadLine()!;
                for (int j = 0; j < Temp.Length; j++)
                    array[i, j] = Temp[j].ToString();
            }
        }

        int NegativeErrors(string[,] image, string[,] negative)
        {
            int count = 0;
            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                    if (image[i, j] == negative[i, j])
                        count++;
            }
            return count;
        }

        Console.Clear();
        Console.Write($"Введите размер изображения: ");
        int[] size = Console.ReadLine()!.Split(',').Select(x => int.Parse(x)).ToArray();
        string[,] image = new string[size[0], size[1]];
        string[,] negative = new string[size[0], size[1]];
        Console.WriteLine("Введите пиксели оригинального изображения построчно");
        FillArray(image);
        Console.WriteLine("Введите пиксели измененного изображения построчно");
        FillArray(negative);
        Console.WriteLine($"Кол-во ошибок преобразования: {NegativeErrors(image, negative)}");
    }
}


// Блок 2. Код для запуска на сайте https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=8&id_topic=121&id_problem=749
// using System;
// using System.IO;
 
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         void FillArray(string[,] array, StreamReader reader)
//         {
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 string Temp = reader.ReadLine();
//                 for (int j = 0; j < Temp.Length; j++)
//                     array[i, j] = Temp[j].ToString();
//             }
//         }
 
//         int NegativeErrors(string[,] image, string[,] negative)
//         {
//             int count = 0;
//             for (int i = 0; i < image.GetLength(0); i++)
//             {
//                 for (int j = 0; j < image.GetLength(1); j++)
//                     if (image[i, j] == negative[i, j])
//                         count++;
//             }
//             return count;
//         }
 
//         StreamReader sr = new StreamReader("input.txt");
//         StreamWriter sw = new StreamWriter("output.txt");
 
//         string[] size = sr.ReadLine().Split();
//         string[,] Image = new string[int.Parse(size[0]), int.Parse(size[1])];
//         string[,] Negative = new string[int.Parse(size[0]), int.Parse(size[1])];
//         FillArray(Image, sr);
//         sr.ReadLine();
//         FillArray(Negative, sr);
//         sw.WriteLine(NegativeErrors(Image, Negative));
 
//         sr.Close();
//         sw.Close();
//     }
// }
