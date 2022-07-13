//int a = 2;
//int b = 3; 
//int c = 7;

int a = new Random().Next(1,100);

Console.WriteLine(a);

int b = new Random().Next(1,100);

Console.WriteLine(b);

int c = new Random().Next(1,10);

Console.WriteLine(c);

int max = a;

if (b > max) max = b;

if (c > max) max = c;

Console.WriteLine("max = ");
Console.WriteLine(max);

