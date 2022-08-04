// На вход координаты двух точек и находит расстояние между ними в 3-х мерном пространстве

Console.Write("Введите координату х1 первой точки: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1 первой точки: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1 первой точки: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату х2 второй точки: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2 второй точки: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2 второй точки: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double distance;

distance = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine(distance);