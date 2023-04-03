﻿Console.WriteLine("Введите размеры массива: Количество столбцов:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество строк:");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, cols];

fillArrayRandom(array);
printArray(array);
/* arraySum(array); */
/* methodNumberSearch(array); */

void fillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToDouble(new Random().Next(-21, 21)) / 10;
    }
    Console.WriteLine("Ваш Массив:");
}
void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();
    }
}
/* void arraySum(int[,] array)
{
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"Среднее арифметическое {j + 1} столбца:");
    Console.WriteLine($"{ sum / array.GetLength(0)} ");
}
} */
/* void methodNumberSearch(int[,] array)
{
    Console.WriteLine("Введите координаты:");
    Console.WriteLine("Номер столбца:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Номер строки:");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a >= m && b >= n)
        Console.WriteLine("Попробуйте снова");
    else
    {
        object c = array.GetValue(a, b);
        Console.WriteLine($"Число по искомым координатом = {c}");
    }
} */