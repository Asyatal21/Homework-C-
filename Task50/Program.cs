// Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве, 
//и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.
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
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.WriteLine("ведите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите число число стобцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine("введите индекс строки i =");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите индеск столбца j=");
int j = Convert.ToInt32(Console.ReadLine());
if (i<=m && j<=n)
{
Console.WriteLine(array[i,j]);
}
else Console.WriteLine("Такого элемента нет в заданном массиве");