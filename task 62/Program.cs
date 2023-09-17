// Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

const int ROW = 4;
const int COL = 4;
const int FIRSTTEN = 4;

int[,] spiralMatrix = GetSpiralMatrix(ROW, COL);
PrintMatrix(spiralMatrix);
Console.WriteLine();

int[,] GetSpiralMatrix(int row, int col)
{
    int[,] spiralMatrix = new int[row, col];
    int size = row * col;
    int valueCounter = 0;
    int step = 0;

    while(valueCounter < size)
    {
        for(int i = step; i < (col - 1) - step || valueCounter == (size - 1); i++)
            spiralMatrix[step, i] = ++valueCounter;
  
        for(int i = step; i < (row - 1) - step; i++)
            spiralMatrix[i, (col - 1) - step] = ++valueCounter;

        for(int i = (col - 1) - step; i > step; i--)
            spiralMatrix[(row - 1) - step, i] = ++valueCounter;
        
        for(int i = (row - 1) - step; i > step; i--)
            spiralMatrix[i, step] = ++valueCounter;

        step++;
    }

    return spiralMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{(matrix[i, j] < FIRSTTEN ? "0" + matrix[i, j] : matrix[i, j] )} ");
            
        Console.WriteLine();
    }
}
