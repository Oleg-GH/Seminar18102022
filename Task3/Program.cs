// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
Console.WriteLine("Введите координаты точки:  ");
Console.Write("x = ");
int x = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Это первая четверть, диапазон обоих координат (0; ∞) ");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Это вторая четверть, диапазон значений  х - (-∞; 0), y - (0; ∞)");
}
if (x < 0 && y < 00)
{
    Console.WriteLine("Это третья четверть, диапазон обеих координат (-∞; 0)");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Это четвертая четверть, диапазон х - (0; ∞), y - (-∞; 0)");
}

