// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу которая на входе принимает целое число N. А на выходке показывает все целе числа в промежутке от -N до N.

Console.WriteLine("Введите целое полное число");
int n = Convert.ToInt32(Console.ReadLine());

int count = n * (-1);

while (count <= n)
{
    Console.Write(count + " ");
    count++;
}