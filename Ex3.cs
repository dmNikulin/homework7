// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] array = new int[5, 5];

void FillArray(int[,] table)
{
    for (int k = 0; k < table.GetLength(0); k++)
    {
        for (int l = 0; l < table.GetLength(1); l++)
        {
            table[k, l] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] block)
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

double[] summary = new double[array.GetLength(1)];

for (int k = 0; k < array.GetLength(1); k++)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        summary[k] = summary[k] + array[n, k];
    }
}

Console.WriteLine();

for (int i = 0; i < summary.Length; i++)
{
    Console.WriteLine($"Среднее арифмитическое ряда №{i+1}: {Math.Round((summary[i]/array.GetLength(0)),2)}.");
}
