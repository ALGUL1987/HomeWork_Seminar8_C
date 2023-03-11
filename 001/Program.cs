/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int rows = new Random().Next(2, 5);
int cols = new Random().Next(2, 5);
/// <summary>
/// Метод, задающий двумерную матрицу с рандомным кол-вом строк и стобцов
/// </summary>
/// <param name="rows"> рандомное кол-во строк </param>
/// <param name="cols"> рандомное кол-во столбцов </param>
/// <returns></returns> Возвращает результат
int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
    return matrix;
}
/// <summary>
/// Метод отображения матрицы в консоли
/// </summary>
/// <param name="matr"></param>
void PrintMatrix(int[,] matr)
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
int[,] resultMatix = GetMatrix(rows, cols);
Console.WriteLine("Исходная матрица");
PrintMatrix(resultMatix);
int[,] SortigRowsMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols - 1; j++)
        {
            for (int m = j + 1; m < cols; m++)
            {
                if (inputMatrix[i, m] > inputMatrix[i, j])
                {
                    int temp = inputMatrix[i, m];
                    inputMatrix[i, m] = inputMatrix[i, j];
                    inputMatrix[i, j] = temp;
                }
            }

        }
    }
    return inputMatrix;
}
Console.WriteLine("Отсортированная матрица");
PrintMatrix(SortigRowsMatrix(resultMatix));