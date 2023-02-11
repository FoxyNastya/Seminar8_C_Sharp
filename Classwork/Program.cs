/*
Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет
 местами первую и последнюю строку массива.
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

void SwapRows(int [,] matrix)
{
    int i = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        i = matrix[0,j];
        matrix[0, j] = matrix[matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0)-1, j] = i;
    }
}
int rows = 4;
int columns = 4;
int [,] matrix = InitMatrix(rows,columns);
PrintMatrix(matrix);
SwapRows(matrix);
Console.WriteLine();
PrintMatrix(matrix);
*/

/*
Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение 
для пользователя.

int GetNumber(string message)
{
    int result =0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("Вы ввелин не корректное число. Повторите ввод"); 
    }

    return result;
}

int [,] InitMatrix(int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
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

int [,] TransporationMatrix(int [,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix [j, i] = matrix[i,j];
        }
    }
    return newMatrix;
}

int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");
int [,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();
int [,] finalMatrix = TransporationMatrix(matrix);
PrintMatrix(finalMatrix);

*/
/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается 
элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза 
1 встречается 1 раз 
2 встречается 1 раз 
8 встречается 1 раз 
9 встречается 3 раза

int [,] InitMatrix(int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
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

Dictionary<int, int> Slovar = new Dictionary<int, int>();
int[,] matrix = InitMatrix(10, 10);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(Slovar.ContainsKey(matrix[i,j]))
            Slovar[matrix[i,j]] = Slovar[matrix[i,j]] + 1;
        else
            Slovar.Add(matrix[i,j], 1);
    }
}

PrintMatrix(matrix);

foreach (var item in Slovar.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{item.Key} встречается {item.Value} раз");
}

/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/
int GetNumber(string message)
{
    int result =0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("Вы ввелин не корректное число. Повторите ввод"); 
    }

    return result;
}

int [,] InitMatrix(int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
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

(int, int) FindIndexMinElement(int [,] matrix)
{
    int minI = 0;
    int minJ = 0;
    int minElement = matrix[0,0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] < minElement)
            {
                minElement = matrix[i,j];
                minI = i;
                minJ = j;
            }
        }
        
    }
    return (minI, minJ);
}

int [,] FinalMatrix(int [,] matrix, int minI, int minJ)
{
    int [,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i == minI) continue;
        n = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j == minJ) continue;
            else
            {
                newMatrix[m, n] = matrix [i, j];
                n++;
            }
        }
        m++;
    }
    return newMatrix;
}

int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");
int [,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();

(int minI, int minJ) = FindIndexMinElement(matrix);
int [,] finalMatrix = FinalMatrix(matrix, minI, minJ);
PrintMatrix(finalMatrix);