// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// using System.Globalization;
// using System.Runtime.Serialization.Formatters;

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}



Console.Write("Введите количество строк массива: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] newMatrix = GetMatrix(lines, columns, minimum, maximum);
PrintMatrix(newMatrix);
int lengt = newMatrix.GetLength(1);
Console.WriteLine("Среднее арифметическое каждого столбца: ");

int[] sum = new int[newMatrix.GetLength(1)];
for (int i = 0; i < newMatrix.GetLength(1); i++)
{
    for (int j = 0; j < newMatrix.GetLength(0); j++)
    {
        sum[i] = sum[i] + newMatrix[j, i];
    }
}

void PrintAverage(int[] sum)
{
    for (int i = 0; i < sum.Length; i++)
    {

        Console.Write(Math.Round(Convert.ToDouble(sum[i]) / newMatrix.GetLength(0), 2) + "\t");
    }

}
PrintAverage(sum);