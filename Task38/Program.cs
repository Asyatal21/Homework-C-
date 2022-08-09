// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
int max = massive[0];
for(int i=1; i<massive.Length; i++)
{
    massive[i] = new Random().Next(-100,100);
    if (massive[i]>max) max = massive[i];
}

int min = massive[0];
for(int i=1; i<massive.Length; i++)
{
    massive[i] = new Random().Next(-100,100);
    if (massive[i]<min) min = massive[i];
}

int result = max - min;
PrintArray(massive);
Console.WriteLine();
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(result); 

