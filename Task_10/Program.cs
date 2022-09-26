//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
Console.WriteLine($"вторая цифра данного числа равна: " + str[1]);
