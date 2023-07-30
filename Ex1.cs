// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] array = new double[4, 4];

void FillArray(double[,] table)
{
    for (int k = 0; k < table.GetLength(0); k++)
    {
        for (int l = 0; l < table.GetLength(1); l++)
        {
            table[k, l] = Math.Round((new Random().NextDouble() * (10 - 1) + 1), 2); // Рандомные вещественные числа от 0 до 10 с округлением
        }
    }
}
void PrintArray(double[,] block)
{
    for (int j = 0; j < block.GetLength(0); j++)
    {
        for (int m = 0; m < block.GetLength(1); m++)
        {
            Console.Write($"{block[j, m]} ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
