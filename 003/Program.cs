// Написать программу масштабирования фигуры
// Написать программу масштабирования фигуры
// задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"

int[] a1 = { 0, 0 };
int[] a2 = { 2, 0 };
int[] a3 = { 2, 2 };
int[] a4 = { 0, 2 };
int k = 4;

Console.WriteLine("Координаты масштабированной фигуры: ");

foreach (int element in a1)
{
    int newa1 = element * k;
    Console.Write($"{newa1} ");
}
Console.WriteLine();
foreach (int element in a2)
{
    int newa2 = element * k;
    Console.Write($"{newa2} ");
}
Console.WriteLine();
foreach (int element in a3)
{
    int newa3 = element * k;
    Console.Write($"{newa3} ");
}
Console.WriteLine();
foreach (int element in a4)
{
    int newa4 = element * k;
    Console.Write($"{newa4} ");
}