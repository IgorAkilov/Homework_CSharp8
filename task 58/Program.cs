// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int rows = Prompt("Введитe количество строк матрицы 1: ");
int columns = Prompt("Введитe количество столбцов матрицы 1: ");
int minValue = Prompt("Введите минимальное значение матрицы 1: ");
int maxValue = Prompt("Введите максиммальное значение матрицы 1: ");
int rows2 = Prompt("ведитe количество строк матрицы 2: ");
int columns2 = Prompt("Введитe количество столбцов матрицы 2:  ");
int minValue2 = Prompt("Введите минимальное значение матрицы 2: ");
int maxValue2 = Prompt("Введите максиммальное значение матрицы 2: ");
int[,] matrix = GetMatrix(rows, columns, minValue, maxValue);
int[,] matrix2 = GetMatrix(rows2, columns2, minValue2, maxValue2);

OutputMatrix(matrix);
Console.WriteLine();
OutputMatrix(matrix2);
Console.WriteLine();
ProdMatrix(matrix, matrix2, columns, rows2);





int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] GetMatrix(int row, int colum, int min, int max)
{
    int[,] array = new int[row, colum];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array[i, j] = new Random().Next(min, max); 
        }
    }
    return array;
}

void OutputMatrix(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write(mat[i, j] + " ");
        }
        Console.WriteLine();
    }
    
}

void ProdMatrix(int[,] matrix, int[,] matrix2, int columns, int rows2)
{
    int[,] prodMatrix = new int[columns, rows2];
    if(columns != rows2)
    {
        Console.WriteLine("Произведение матриц невозможно");
        return;
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                prodMatrix[i, j] += matrix[i, k] * matrix2[k, j];
            }
            Console.Write(prodMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
