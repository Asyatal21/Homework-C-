int a = 5;
int b = 7; 

int max = a;

if (b > max) max = b;

int min = a;

if (b < a) min = b;

Console.WriteLine(max);

Console.WriteLine(min);
