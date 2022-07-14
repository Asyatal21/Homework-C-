//int a = 2;
//int b = 3; 
//int c = 7;


Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;

if (c > max) max = c;

Console.WriteLine("max = ");
Console.WriteLine(max);

