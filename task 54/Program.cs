// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

const int ROW = 3;
const int COL = 4;
const int MIN = 1;
const int MAX = 9;

int[,] matrix = GetRandomMatrix(ROW, COL, MIN, MAX);
PrintMatrix(matrix);
Console.WriteLine();

MatrixRowSort(matrix);
PrintMatrix(matrix);
Console.WriteLine();

void MatrixRowSort(int[,] matrix) 
{
    int temp = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(0); j++)
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
}

int[,] GetRandomMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random random = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            matrix[i, j] = random.Next(min, max + 1);

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");

        Console.WriteLine();
    }
}
