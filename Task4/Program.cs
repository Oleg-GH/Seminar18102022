// Найти расстояние между точками в пространстве 2D/3D

Console.Clear();
Console.WriteLine("В каком пространстве надо найти расстояние между точками, 2D или 3D? ");
Console.WriteLine("Введите 2, если в 2D, или 3, если в 3D: ");
int d = int.Parse(Console.ReadLine());
double distance = 0;

if (d == 2)
{
    Console.WriteLine("Введите две координаты точки А: ");
    Console.Write("xa = ");
    int xa = int.Parse(Console.ReadLine());
    Console.Write("ya = ");
    int ya = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите две координаты точки B: ");
    Console.Write("xb = ");
    int xb = int.Parse(Console.ReadLine());
    Console.Write("yb = ");
    int yb = int.Parse(Console.ReadLine());
    int result = (xb - xa) * (xb - xa) + (yb - ya) * (yb - ya);
    distance = Math.Sqrt(result);
    Console.WriteLine($"Расстояние АВ = {distance}");
}
else
{
    if (d == 3)
    {
        Console.WriteLine("Введите три координаты точки А: ");
        Console.Write("xa = ");
        int xa = int.Parse(Console.ReadLine());
        Console.Write("ya = ");
        int ya = int.Parse(Console.ReadLine());
        Console.Write("za = ");
        int za = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите три координаты точки B: ");
        Console.Write("xb = ");
        int xb = int.Parse(Console.ReadLine());
        Console.Write("yb = ");
        int yb = int.Parse(Console.ReadLine());
        Console.Write("zb = ");
        int zb = int.Parse(Console.ReadLine());
        int result = (xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za);
        distance = Math.Sqrt(result);
        Console.WriteLine($"Расстояние АВ = {distance}");
    }
    else
    {
        Console.WriteLine("Некорректное значение, попробуйте снова.");
    }
}
