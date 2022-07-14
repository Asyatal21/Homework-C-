//int a = 5;
//int b = 7; 

//int a = new Random().Next(1,10);

//Console.WriteLine(a);

//int b = new Random().Next(1,10);

//Console.WriteLine(b);

Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");

int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;

int min = a;

if (b < a) min = b;

Console.WriteLine("max = ");

Console.WriteLine(max);

Console.WriteLine("min = ");

Console.WriteLine(min);
