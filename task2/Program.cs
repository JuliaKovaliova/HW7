/* Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

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

void PrintElement (int [,] array)
{
    Console.WriteLine("Enter line number: ");
    int userNumbLine = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter column number: ");
    int userNumbColumn = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++);
    }
    if (userNumbLine > array.GetLength(0) || userNumbColumn > array.GetLength(1))
    {
        Console.WriteLine("There is no such number in the array!");
    }
    else
    {
        Console.WriteLine($"Element is: {array[userNumbLine,userNumbColumn]}");
    }
}

int [,] array = CreatArray (5,5);
PrintArray (array);
PrintElement (array);
