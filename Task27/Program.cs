// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

Console.WriteLine("Введите число");

string number = Console.ReadLine();

int length = number.Length;

int summa = 0;


for (int i = 0; i<length;i++)

{
    summa =  summa+int.Parse(number[i].ToString());
}

Console.WriteLine (summa);



