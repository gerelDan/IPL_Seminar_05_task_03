﻿// Задача 3: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(min, max+1);
        }
    }
    return result;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == arr.GetLength(1)-1)
            {
                Console.Write($"{arr[i,j]}");
            }
            else Console.Write($"{arr[i,j]}, ");
        }
        Console.WriteLine("]");
    }    
}
int[] MinRow(int[,] arr)
{
    int min = arr.GetLength(1) * 10;
    int minIndex = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        if (sum < min)
        {
            min = sum;
            minIndex = i;
        }
    }
    int[] result = new int[arr.GetLength(1)];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = arr[minIndex, i];
    } 
    return result;
}
int[,] array = FillArray(4, 5, 1, 10);
PrintArray(array);
int[] res = MinRow(array);
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", res)}]");