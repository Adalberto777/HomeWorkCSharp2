Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет");

Console.WriteLine("Enter a positive integer");

int number = int.Parse(Console.ReadLine());

int number1 = number;
int i = 1;
if(number / 100 == 0)
{
    Console.WriteLine("no third number");
}
else
{
   while(number / i > 99)
   {
    number1 = number/i;
    i = i * 10;    
   } 
   Console.WriteLine(number1% 10);
}

