// Задача 3: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random.Next(min, max);
        }
    }
    return result;
}