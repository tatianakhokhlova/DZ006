// Написать программу масштабирования фигуры

System.Globalization.NumberFormatInfo numberInfo = System.Globalization.NumberFormatInfo.InvariantInfo;
Console.WriteLine("Введите координаты:");
string inputLine = Console.ReadLine();
Console.WriteLine("Введите множитель:");
double inputMult = double.Parse(Console.ReadLine(), numberInfo);
Console.WriteLine(ChangeSize(inputLine, inputMult));


string ChangeSize(string input, double multiple)
{
    string result = "";
    string[] points = input.Replace("(", "").Replace(")", "").Split(" ");
    foreach (string point in points)
    {
        string x = $"{double.Parse(point.Split(",")[0], numberInfo) * multiple}".Replace(",", ".");
        string y = $"{double.Parse(point.Split(",")[1], numberInfo) * multiple}".Replace(",", ".");
        result += $"({x},{y}) ";
    }
    return result;
}