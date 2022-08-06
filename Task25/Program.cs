// Напишите цикл, которое принимает на вход два числа (a и b) и возводит число a в степень b

Console.WriteLine("Введите число a ");
int a =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b ");
int b =  Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Math.Pow(a,b));

int result = 1;

for (int i = 1; i <= b; i++ )
{
    result = result*a;
}
Console.WriteLine(result);
