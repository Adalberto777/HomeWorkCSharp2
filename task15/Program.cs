Console.WriteLine("программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");

Console.WriteLine("Enter a day of week (number from 1 to 7)");

int number = int.Parse(Console.ReadLine());

if(number < 6)
{
    Console.WriteLine("рабочий день");
}
else
{
    Console.WriteLine("выходной день");
}
