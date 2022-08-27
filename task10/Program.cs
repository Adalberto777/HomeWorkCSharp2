Console.WriteLine("Программа для вывода второй по счету цифры, трехзначного числа");

int number = new Random().Next(100,1000);

Console.WriteLine($"Случайное трехзначное число: {number}");

Console.WriteLine($"вторая цифра: {number} это цифра {number % 100 / 10}");