/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int rowsFirstMatrix = new Random().Next(2, 10);
int colsFirstMatrix = new Random().Next(2, 10);
int rowsSecondMatrix = colsFirstMatrix;
int colsSecondMatrix = new Random().Next(2, 10);
double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble() * 100 - 50), 1);
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
            Console.Write(Math.Round(matr[i, j], 1) + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Первая матрица");
double[,] firstMatix = GetMatrix(rowsFirstMatrix, colsFirstMatrix);
PrintMatrix(firstMatix);
Console.WriteLine("Вторая матрица");
double[,] secondMatix = GetMatrix(rowsSecondMatrix, colsSecondMatrix);
PrintMatrix(secondMatix);
double[,] ProductMatrix(double[,] firstMatrix, double[,] secondMatrix)
{
    double[,] resultMatrix = new double[rowsFirstMatrix, colsSecondMatrix];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int m = 0; m < firstMatrix.GetLength(1); m++)
            {
                resultMatrix[i, j] += firstMatrix[i, j] * secondMatrix[m, j];
            }
        }
    }
    return resultMatrix;
}
double[,] resultMatix = ProductMatrix(firstMatix, secondMatix);
Console.WriteLine("Произведение матриц");
PrintMatrix(resultMatix);
