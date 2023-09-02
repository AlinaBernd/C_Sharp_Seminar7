
// Доп. задача. Написать программу, преобразующую число из десятеричной системы счисления в двоичную

/* string DecimalToBinary(int decimalNumber) 
{
    string binaryNumber = "";

    while (decimalNumber > 0)
    {
        int remainder = decimalNumber % 2;
        binaryNumber = remainder + binaryNumber; // Добавляем остаток в начало двоичного числа
        decimalNumber /= 2;
    }

    return binaryNumber;
}

Console.Write("Inrut a number: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string binaryNumber = DecimalToBinary(decimalNumber);

Console.WriteLine($"A number {decimalNumber} in binary: {binaryNumber}");
*/
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] CreateRandomMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().NextDouble(); // Генерируем случайные числа
        }
    }
    return matrix;
}

void WriteMatrix(double[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input the number of rows of the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns of array: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] myMatrix = CreateRandomMatrix(rows, columns);
WriteMatrix(myMatrix);
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateRandomMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next();
        }
    }
    return matrix;
}

void WriteMatrix(int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

bool SearchNumber(int[,] matrix, int i, int j) //  Функция ищет число в массиве по указанному индексу
{
    if (i < 0 || j < 0 || i >= matrix.GetLength(0) || j >= matrix.GetLength(1))
    {
        Console.WriteLine("The number does not exist in the array.");
        return false;
    }
    Console.WriteLine("Number with specified index: " + matrix[i, j]);
    return true;
}

Console.Write("Input the number of rows of the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns of the array: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] myMatrix = CreateRandomMatrix(rows, columns);
WriteMatrix(myMatrix);
Console.Write("Input an index of row of the array to search: ");
int rowSearch = Convert.ToInt32(Console.ReadLine());
Console.Write("Input an index of column of the array to search: ");
int columnSearch = Convert.ToInt32(Console.ReadLine());
SearchNumber(myMatrix, rowSearch, columnSearch);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int[,] CreateRandomMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next();
        }
    }
    return matrix;
}
void WriteMatrix(int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int AverageRow (int[,] matrix)
        int[] columnSums = new int[columns];

        // Находим сумму элементов каждого столбца
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                columnSums[j] += array[i, j];
            }
        }

        double[] columnAverages = new double[columns];

        // Находим среднее арифметическое элементов каждого столбца
        for (int j = 0; j < columns; j++)
        {
            columnAverages[j] = (double)columnSums[j] / rows;
        }

        // Выводим средние арифметические элементов каждого столбца
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine("Среднее арифметическое элементов столбца {0}: {1}", j+1, columnAverages[j]);
        }
    }
*/