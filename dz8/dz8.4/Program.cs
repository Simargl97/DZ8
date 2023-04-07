int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int c = 0; c < array3D.GetLength(2); c++)
            {
                Console.Write($"{array3D[i, j, c]}({i},{j},{c}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int c = 0; c < arr.GetLength(2); c++)
            {
                arr[c, i, j] += count;
                count += 3;
            }
        }
    }
}