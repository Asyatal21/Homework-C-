//int a = 5;
//int b = 7; 

int a = new Random().Next(1,10);

Console.WriteLine(a);

int b = new Random().Next(1,10);

Console.WriteLine(b);

int max = a;

if (b > max) max = b;

int min = a;

if (b < a) min = b;

Console.WriteLine("max = ");

Console.WriteLine(max);

Console.WriteLine("min = ");

Console.WriteLine(min);
