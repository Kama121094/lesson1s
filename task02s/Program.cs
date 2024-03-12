// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


Console.WriteLine("Введите целое полное число");
int n = Convert.ToInt32(Console.ReadLine());

int count = n * (-1);

while (count <= n)
{
    Console.Write(count + " ");
    count++;
}