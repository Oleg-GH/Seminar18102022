// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Clear();
Console.Write("Введите порядковый номер дня недели от 1 до 7:  ");
int day = int.Parse(Console.ReadLine());

if (day < 1 | day > 7)
{
    Console.WriteLine("Некорректное число, попробуйте снова");
}
else
{
    if (day == 6 | day == 7)
    {
        Console.WriteLine("Этот день недели является выходным");
    }
    else
    {
        Console.WriteLine("Этот день не является выходным");
    }
}
