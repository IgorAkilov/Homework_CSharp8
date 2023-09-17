// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// Номерация строк начинается с 1

int rows = Prompt("Введитe размер прямоугольного массива: ");
int columns = rows - 1;
int minValue = Prompt("Введите минимальное значение массива: ");
int maxValue = Prompt("Введите максиммальное значение массива: ");
int[,] myArray = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine("Исходный массив массив");
OutputArray(myArray);
Console.WriteLine("Сумма чисел строк");
SearchMinIndex(myArray);


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] GetArray(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    
}

void SearchMinIndex(int[,] myarray)
{
    int[] sum = new int[myarray.GetLength(0)];
    for (int i = 0; i < myarray.GetLength(0); i++)
    { 
        for (int j = 0; j < myarray.GetLength(1); j++)
        {
            sum[i] += myarray[i, j];
        }
        Console.Write(sum[i] + " ");

    }
    Console.WriteLine();


    int min = sum[0];
    int index = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if(sum[i] < min)
        {
            index = i;
            min = sum[i];

        }

    }Console.WriteLine($"Минимальная сумма строки {min} ее номер {index + 1}");

}
