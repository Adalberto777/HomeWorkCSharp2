Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет");

Console.WriteLine("Enter a positive integer");

string input = Console.ReadLine();
int size = input.Length;

if(size < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(input[2]);
}