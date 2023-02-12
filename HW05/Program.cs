/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] matrix = new int[4,4];

void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 16);
        }
    }
}

void PrintMatrix(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write(m[i, j].ToString().PadLeft(4));
        }
        Console.WriteLine();
    }
}
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

matrix[0, 0] = 01;
matrix[0, 1] = 02;
matrix[0, 2] = 03;
matrix[0, 3] = 04;
matrix[1, 3] = 05;
matrix[2, 3] = 06;
matrix[3, 3] = 07;
matrix[3, 2] = 08;
matrix[3, 1] = 09;
matrix[3, 0] = 10;
matrix[2, 0] = 11;
matrix[1, 0] = 12;
matrix[1, 1] = 13;
matrix[1, 2] = 14;
matrix[2, 2] = 15;
matrix[2, 1] = 16;

PrintMatrix(matrix);

