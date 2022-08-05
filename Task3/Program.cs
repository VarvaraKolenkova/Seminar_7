//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10); 
        }
    }
    return matrix;  
}

void ArithmeticMeanOfTheColumns(int[,] col)
{
    double[] sum = new double[col.GetLength(1)];
    for (int i = 0; i < col.GetLength(1); i++)
    {
        for (int j = 0; j < col.GetLength(0); j++)
        {
            sum[i] += col[j,i];
        }   
    } 
    System.Console.WriteLine();
    for (int i = 0; i < col.GetLength(1); i++)
    {
        double result = 0;
        result = Math.Round(sum[i]/col.GetLength(0), 1);
        System.Console.Write($"{result}; ");
        }    
}                     
                             
void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i,j], 3} | ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetMatrix(3,4); 
PrintMatrix(array); 
ArithmeticMeanOfTheColumns(array);
