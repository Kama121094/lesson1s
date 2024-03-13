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


// Console.WriteLine("введите целое трехзначное чесло ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num / 100;
// int num3 = num % 10;
// Console.WriteLine(num1 + num3);

// Большее из двух чисел.

// Console.WriteLine("введите первое целое чесло ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе целое чесло ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber == secondNumber)
// {
//     Console.WriteLine("числа равны");
// }
// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("первое число больше второго");
// }
// if (firstNumber < secondNumber)
// {
//     Console.WriteLine("второе число большн первого");
// }


// Максимальное из трех чисел.
// int a = 6;
// int b = 9;
// int c = 3;

// int max = a;
//   if (max < b)
// {
//   max = b;
// }
//   if (max < c)
// {
//   max = c;
// }

// Console.WriteLine(max);

// Вывести все четные чесла

using System.Globalization;

// Console.WriteLine("Введите целое полное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 2;

// while (count <= number)
// {
//     Console.Write(count + " ");
//     count = count + 2;
// }


// Проверка на четность.


int number = Convert.ToInt32(Console.ReadLine());

 if ((number%2)==0) 
 {
    Console.WriteLine("четное");
 } 
 else
 {
    Console.WriteLine("нечетное"); 
 }

        