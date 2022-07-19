// На вход трехзначное число, на выходе вторая цифра этого числа

Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine());


int b =  a / 10 % 10;

int c = b % 10;

Console.WriteLine(c);
