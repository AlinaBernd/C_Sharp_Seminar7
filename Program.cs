
// Доп. задача. Написать программу, преобразующую число из десятеричной системы счисления в двоичную

/* string DecimalToBinary(int decimalNumber) // Функция, которая преобразует десятичное число в двоичное число
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

double[,] CreateRandomMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = random.Next(); // Генерируем случайные числа
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
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

