// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая на входе принимает два целых числа и проверяет является ли первое число квадратом второго числа.  
// a = 25 , b = 5  => yes
// a = 2 , b = 10 => no
// a = 9 , b = -3 => yes
// a = -4 , b = 16 => no
 
Console.WriteLine ("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine ("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine()); 

if (num2*num2 == num1)
{
  Console.WriteLine ("Первое число является квадратом второго");  
}
else 
{
    Console.WriteLine ("Первое число не является квадратом второго");
}