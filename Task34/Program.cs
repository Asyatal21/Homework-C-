// Задайте массив заполненный случайными положительными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];

int count = 0; //дополнительная переменная, кот будет считать количество четных чисел

for(int i=0; i<massive.Length; i++) 
{

    massive[i] = new Random().Next(0,100); 
    if(massive[i] % 2 == 0)
    {
        count = count+1;
    }
    else count = count;

}
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
PrintArray(massive);
Console.WriteLine();
Console.WriteLine ($"Количество четных элементов:{count}");                    