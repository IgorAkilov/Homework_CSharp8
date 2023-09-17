// Задача 60: ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

const int ROW =  2;
const int COL =  2;
const int CELL = 2;
const int MIN =  0;
const int MAX =  100;

int[,,] cube = GetRandomCube(ROW, COL, CELL, MIN, MAX);
PrintCube(cube);

int[,,] GetRandomCube(int row, int col, int cell, int min, int max)
{
    int[,,] cube = new int[row, col, cell];
    Random random = new Random();
    int value = 0;

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            for(int k = 0; k < cell; k++)
            {
                value = random.Next(min, max);
                
                while(IsCubeHasSameValue(cube, value))
                    value = random.Next(min, max);

                cube[i, j, k] = value;
            }

    return cube;
}

void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for(int k = 0; k < cube.GetLength(2); k++)
                Console.Write($"{cube[i, j, k], -3}({i},{j},{k})  ");                
                
            Console.WriteLine();
        }
}

bool IsCubeHasSameValue(int[,,] cube, int value)
{
    for (int i = 0; i < cube.GetLength(0); i++)
        for (int j = 0; j < cube.GetLength(1); j++)
            for(int k = 0; k < cube.GetLength(2); k++)
                if(cube[i, j, k] == value) {Console.WriteLine($"Совпадение вхождения {value} {i} {j} {k}"); return true;};

    return false;
}
