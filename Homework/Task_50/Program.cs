// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите мин число: ");
int minRandom = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс число: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());
int[,] array = GetMatrix(rows, columns, minRandom, maxRandom);

Console.Write("Введите строку искомого элемента: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец искомого элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

if (line>=0 & line<=rows & column>=0 & column<=columns)
{
Console.Write($"Искомый элемент: {array[line, column]}");
}
else Console.Write($"Такого числа в массиве нет");