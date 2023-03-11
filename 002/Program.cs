/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int rows = new Random().Next(2, 10);
int cols = new Random().Next(2, 10);
double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble() * 100 - 50), 2);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int indexMinRows = 0;
double minSum = int.MaxValue;
void ShowsMinSumRowsMatrix(double[,] sumMatr)
{
    for (int i = 0; i < sumMatr.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < sumMatr.GetLength(1); j++)
        {
            sum = sum + sumMatr[i, j];
            if (minSum > sum)
            {
                minSum = sum;
                indexMinRows = i;
            }
        }
        Console.WriteLine($"Сумма чисел {i}-строки равна {Math.Round(sum, 2)}");
    }
    Console.WriteLine($"Сумма {Math.Round(minSum, 2)} строки {indexMinRows} является минимальной");
}

double[,] resultMatix = GetMatrix(rows, cols);
PrintMatrix(resultMatix);
ShowsMinSumRowsMatrix(resultMatix);