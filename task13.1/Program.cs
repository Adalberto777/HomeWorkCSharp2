Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет");

Console.WriteLine("Enter a positive integer");

int number = int.Parse(Console.ReadLine());


if(number < 100)
{
    Console.WriteLine("no third number");
}
else
{
   while(number > 999)
   {
    number /= 10;     // number = number / 10
   } 
   Console.WriteLine(number % 10);
}

