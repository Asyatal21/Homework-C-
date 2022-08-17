// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void PrintArray(double[,] array)
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
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}
Console.WriteLine("ведите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите число число стобцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);