/*
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int [,] CreatArray (int lin, int col)
{
    int [,] array = new int [lin, col];
    for (int i = 0; i < lin; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array [i,j] = new Random().Next(0,10);
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
    Console.WriteLine ();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] array = CreatArray (5,5);
PrintArray (array);

void SrArColArray (int [,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        {
            double sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = sum + arr [i,j];
            }
            Console.Write($"{sum/arr.GetLength(0)}, ");
        }
        Console.WriteLine("\b\b.");
}

SrArColArray (array);
