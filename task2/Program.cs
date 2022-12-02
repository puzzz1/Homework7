/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(- deviation, deviation + 1);
        }

    }
    return array;
}
void printArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void ResultArray (int [,] array)
{
    double midlmean = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + array[i,j];
        }
        midlmean = result / array.GetLength(0);
        Console.WriteLine($" Среднеарифмметическое столбца {i} - {result}");
    }
    {
        
    }
}

int[,] array = generate2DArray(3, 4, 10);
printArray(array);
Console.WriteLine();
ResultArray(array);