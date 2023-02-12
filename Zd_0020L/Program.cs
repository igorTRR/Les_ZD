﻿

// string[,]table =new string[2,5];

// table[1,2] = "слово";

// for(int rows =0; rows <2; rows++)
// {
//     for (int colums =0; colums <5; colums++)
//     {
//         Console.WriteLine($"-{table[rows,colums]}");
//     }
// }

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]} ");
         }
    Console.WriteLine();
    }
}
// int[,]matrix = new int[3, 4];
// PrintArray(matrix);

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    Console.WriteLine();
    }
}
Console.Clear();
int[,]matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
