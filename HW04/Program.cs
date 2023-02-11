/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("Вы ввелин не корректное число. Повторите ввод");
    }

    return result;
}

int[,,] InitMatrix(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           for (int k = 0; k < depth; k++)
           {
            matrix[i, j, k] = rnd.Next(10, 99);
           }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int y = 0; y < matrix.GetLength(0); y++)
    {
        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.WriteLine($"{matrix[z, x, y]}({z},{x},{y}) ");
            }
            Console.WriteLine();
        }
    }
}


int y = GetNumber("Введите количество строк массива");
int x = GetNumber("Введите количество столбцов массива");
int z = GetNumber("Введите количество этажей массива");
int[,,] matrix = InitMatrix(y, x, z);
PrintMatrix(matrix);
