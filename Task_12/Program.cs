//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.WriteLine("Введите любое число:" );
int number = Convert.ToInt32(Console.ReadLine());
string numEl = Convert.ToString(number);
if (numEl.Length > 2){
  Console.WriteLine("третья цифра вашего числа: " + numEl[2]);
  }
else {
  Console.WriteLine("  третьей цифры нет");
}