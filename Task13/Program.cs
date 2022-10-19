// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();
Console.Write("Введите два числа:  ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("И второе:   ");
int numberB = int.Parse(Console.ReadLine());

if (numberA * numberA == numberB)
{
    Console.WriteLine($"{numberB} является квадратом числа {numberA}");
}
else  
{
    if (numberB * numberB == numberA)
    {
        Console.WriteLine($"{numberA} является квадратом числа {numberB}");
    }  
}     
if (numberA * numberA != numberB && numberB * numberB != numberA)
{
    Console.WriteLine("Ни первое, ни второе числа не являются квадратом другого");
}

