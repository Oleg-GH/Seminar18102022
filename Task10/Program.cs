//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5    782 -> 8      918 -> 1

//Console.Clear();
Console.Write("Введите трехзначное число от 100 до 999: ");
int number = int.Parse(Console.ReadLine());
int digit = 0;

if(number < 100 | number > 999)
{
    Console.WriteLine("Некорректное значение, попробуйте снова");
}
else
{
    digit = (number - number%10)/10%10;
    Console.WriteLine(digit);
}
