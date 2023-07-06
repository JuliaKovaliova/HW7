// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double [,] CreatArray (int lin, int col)
{
    double [,] array = new double [lin, col];
    for (int i = 0; i < lin; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array [i,j] = Math.Round((new Random().NextDouble()*100),2);
        }
    }
    return array;
}

void PrintArray (double [,] array)
{
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

Console.WriteLine("Enter count of lines: ");
int userLines = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());

double [,] array = CreatArray (userLines,userColumns);
PrintArray (array);

