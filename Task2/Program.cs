// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет/
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m,n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max+1); 
        }
    }
    return matrix;
}

void FindElement(int[,] col, int rowfind, int columnfind)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if(i==rowfind && j==columnfind) 
            Console.WriteLine(col[i,j]);      
        }                        
    }
    if(rowfind < 0 | rowfind >col.GetLength(0)-1 | columnfind<0 | columnfind>col.GetLength(1)-1) 
    Console.WriteLine("Такого элемента нет в массиве "); 
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

int[,] array = GetMatrix(3,4, 1, 10); 
PrintMatrix(array); 

System.Console.WriteLine();
Console.WriteLine("Введите индекс строки: ");
int rowfind = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int columnfind = Convert.ToInt32(Console.ReadLine());
FindElement(array, rowfind, columnfind); 
