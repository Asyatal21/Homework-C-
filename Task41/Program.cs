//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, -567, 89, 223-> 3

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];
int i = 0;
while (i < size)
{
    Console.WriteLine("Введите элемент массива");
    massive[i] = int.Parse(Console.ReadLine());
    i++;
}
for (i=0; i<size; i++)
Console.WriteLine("Элемент["+i+"]:"+massive[i]);
Console.ReadKey();

int count = 0; //дополнительная переменная, кот будет считать количество положительных чисел

for(i=0; i<massive.Length; i++) 
{
    if(massive[i] > 0)
    {
        count = count+1;
    }
    else count = count;
}

Console.WriteLine();
Console.WriteLine ($"Количество положительных элементов:{count}");        