// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
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
            array[i, j] = new Random().Next(1,10); 
        }
    }
}
Console.WriteLine("ведите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите число число стобцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
double Midlsumm = 0;

void FindMidlsumm(int[,]array)

{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Midlsumm = 0;
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
            Midlsumm = Midlsumm+array[j,i];
            }
            Console.WriteLine("среднее арифмитическое в "+(i+1)+"столбце равно: "+Math.Round(Midlsumm/i,2));
        }  
    }
}
FillArray(array);
PrintArray(array);
FindMidlsumm(array);