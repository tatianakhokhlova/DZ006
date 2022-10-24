void CrossPoint(int k1, int b1, int k2, int b2)
{
int x = (b1-b2)/(k2-k1);
int y = (k2*b1-k1*b2)/(k2-k1);
if(k1==k2) Console.Write("Заданные прямые не пересекаются!");
else
Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}

Console.WriteLine("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "0");
CrossPoint(k1,b1,k2,b2);