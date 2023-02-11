/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
//See https://aka.ms/new-console-template for more information
int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
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
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}
 
int SumStringMatrix(int[,] matrix)
{
    int sum = 0;
    int minsum = 0;
    int minline = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            minsum += matrix[i, j];
        }
        
        if (i == 0)
        {
            minsum = sum;
            minline = i;
        }
        else if (sum > minsum)
        {
            minline = i;
            minsum = sum;
        }
    }
    return minline;
}
Console.WriteLine("Введите одинаковое количество строк и столбцов");
 int rows = Convert.ToInt32(Console.ReadLine());
 int columns = rows;
 int [,] matrix = InitMatrix(rows,columns);
 PrintMatrix(matrix);
 Console.WriteLine($"Номер строки с наименьшей суммой элементов: {SumStringMatrix(matrix) + 1}");