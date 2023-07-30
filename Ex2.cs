// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int[,] array = new int[7, 6];

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

int[] position = new int [2];

Console.Write("Введите строку элемента: ");
position[0]= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец элемента: ");
position[1] = Convert.ToInt32(Console.ReadLine());

if (position[0] > array.GetLength(0) - 1 || position[1] > array.GetLength(1) -1)
{
    Console.WriteLine("Такого числа нет!");
}

else Console.WriteLine(array[position[0],position[1]]);

