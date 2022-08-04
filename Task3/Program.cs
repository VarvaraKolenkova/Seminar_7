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

void FindElement(int[,] col)
{
    int size = col.GetLength(1);
    int[] sum = new int[size];
    for (int i = 0; i < col.GetLength(1); i++)
    {
        for (int j = 0; j < col.GetLength(0); j++)
        {
            sum[i] += col[j,i];
            System.Console.WriteLine(sum[i]);
        }   
    } 
    System.Console.WriteLine();
    for (int i = 0; i < col.Length; i++)
    {
        int result = 0;
        result = sum[i]/(col.GetLength(0));
        System.Console.WriteLine(result);
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

FindElement(array);

