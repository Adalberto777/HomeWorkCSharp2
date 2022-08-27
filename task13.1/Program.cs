Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет");

Console.WriteLine("Enter a positive integer");

int number = int.Parse(Console.ReadLine());
int b = number % 100;
Console.WriteLine(b);
if(number % 100 == 0 && number % 100 == number)
Console.WriteLine("no fre number");

