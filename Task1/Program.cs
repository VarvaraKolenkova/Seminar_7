// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
double[,] GetMatrix(int m, int n) 
{
    double[,] matrix = new double[m,n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(rnd.NextDouble() * 100, 2); 
        }
    }
    return matrix;
}

void PrintMatrix(double[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i,j], 7} | ");
        }
        Console.WriteLine();
    }
}

double[,] array = GetMatrix(3, 4); 
PrintMatrix(array); 
