// На вход число от 1 до N, а на выходе таблица кубов от 1 до N
Console.WriteLine("Введите число");
int a =  Convert.ToInt32(Console.ReadLine());
int b = 1;
while(b <= a)
{
    Console.WriteLine(b*b*b);
    b = b+1; 
}


