// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.    6 -> да    7 -> да     1 -> нет

//Console.Clear();
Console.Write("Введите число от 1 до 7:    ");
int day = int.Parse(Console.ReadLine());

if(day > 7 | day < 1)
{
    Console.WriteLine("Некорректное число, попробуйте снова.");
}
else
{
    if(day == 6 | day == 7)
    {   
        Console.WriteLine($"{day} -> да");
    }
    else
    {
        Console.WriteLine($"{day} -> нет");
    }
}    