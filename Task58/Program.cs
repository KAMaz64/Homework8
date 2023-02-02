/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication (int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix2.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int x = 0; x < matrix1.GetLength(1); x++)
            {
                resultMatrix[i, j] += matrix1[i, x] * matrix2[x, j];
            }
        }
        
    }
    return resultMatrix;
}

Console.Clear();

Console.Write("Введите количество строк матрицы 1: ");
int rows1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы 1: ");
int columns1 = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элемента матрицы 1: ");
int min1 = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента матрицы 1: ");
int max1 = int.Parse(Console.ReadLine());

int[,] newMatrix1 = GetArray(rows1, columns1, min1, max1);
PrintArray(newMatrix1);
Console.WriteLine();

Console.Write("Введите количество строк матрицы 2: ");
int rows2 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы 2: ");
int columns2 = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элемента матрицы 2: ");
int min2 = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента матрицы 2: ");
int max2 = int.Parse(Console.ReadLine());

int[,] newMatrix2 = GetArray(rows2, columns2, min2, max2);
PrintArray(newMatrix2);
Console.WriteLine();

if (newMatrix1.GetLength(0) != newMatrix2.GetLength(1))
{
    Console.WriteLine("Заданные матрицы невозможжно перемножить!");
}
else
{
    Console.WriteLine("Результат перемножения матриц:  ");
    PrintArray(MatrixMultiplication(newMatrix1, newMatrix2));
}








