/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] InitMatrix1(int rows, int columns)
{
    int[,] matrix1 = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix1[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix1;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}


int[,] InitMatrix2(int rows, int columns)
{
    int[,] matrix2 = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix2[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix2;
}

int[,] MxM(int[,] matrix1, int[,] matrix2)
{
    int sum = 0;
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            sum = 0;
            for (int X = 0; X < matrix2.GetLength(0); X++)
            {
                sum += matrix1[i, X]*matrix2[X, j];
            }
            matrix3[i, j] = sum;
        }
    }
    return matrix3;
}


Console.WriteLine("Введите количество строк первой матрицы");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = InitMatrix1(rows, columns);
Console.WriteLine();
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Введите количество строк второй матрицы");
rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы");
columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = InitMatrix2(rows, columns);
Console.WriteLine();
PrintMatrix(matrix2);

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] matrix3 = MxM (matrix1, matrix2);
    Console.WriteLine("Результат умножения матриц: ");
    PrintMatrix(matrix3);
}
else 
{
Console.WriteLine();
Console.Write("Умножение первой и второй матрицы невозможно! ");
Console.WriteLine("(Необходимо ввести число столбцов первой матрицы равным числу строк второй матрицы)");
}