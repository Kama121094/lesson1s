// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая на входе принимает целое число и на выходе показывает сумму первой и последней цифры этого числа.
// Пример 465=>10; 762=> 9. 

// Console.WriteLine("введите целое трехзначное чесло ");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num >= 100 && num <= 999) || (num >= -999 && num <= -100))
// {
//     int firstDigit = num/100;
//     int lastDigit = num % 10;
//     int sum = firstDigit + lastDigit;
//     Console.WriteLine(sum);
// }
// else 
// {
//     Console.WriteLine("Нукорректный ввод");
// }


Console.WriteLine("введите целое трехзначное чесло ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 100;
int num3 = num % 10;
Console.WriteLine(num1 + num3);