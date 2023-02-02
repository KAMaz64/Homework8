int[,,] newArray3D = new int[2, 2, 2];
FillArray3D(newArray3D);
PrintIndexOf3DArray(newArray3D);


void PrintIndexOf3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray3D(int[,,] inArray)
{
    int count = 10;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                inArray[k, i, j] += count;
                count += 3;
            }
        }
    }
}
